using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class RoundedTextBox : TextBox
{
    // Importar la función de la API de Windows para crear una región con bordes redondeados
    [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,      // Coordenada izquierda
        int nTopRect,       // Coordenada superior
        int nRightRect,     // Coordenada derecha
        int nBottomRect,    // Coordenada inferior
        int nWidthEllipse,  // Ancho de la elipse
        int nHeightEllipse  // Altura de la elipse
    );

    private int padding = 5; // Tamaño del padding

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        // Ajustar la altura del input aquí
        this.Height = 30; // Cambia el valor según la altura deseada
        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
    }

    // Método para redibujar los bordes personalizados
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Dibujar el borde redondeado
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, 15, 15, 180, 90);
            path.AddArc(Width - 15, 0, 15, 15, 270, 90);
            path.AddArc(Width - 15, Height - 15, 15, 15, 0, 90);
            path.AddArc(0, Height - 15, 15, 15, 90, 90);
            path.CloseAllFigures();

            // Cambiar el color y el grosor del borde
            using (Pen pen = new Pen(Color.FromArgb(0, 20, 27), 2f))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        // Dibujar el texto con padding
        Rectangle textRect = new Rectangle(padding, padding, this.Width - 2 * padding, this.Height - 2 * padding);
        TextRenderer.DrawText(e.Graphics, this.Text, this.Font, textRect, this.ForeColor);
    }

    // Método para redondear automáticamente el borde al redimensionar el control
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
    }
}

