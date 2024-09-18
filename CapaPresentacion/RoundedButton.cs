using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    // Propiedad para el ícono
    private Image icon;

    public Image Icon
    {
        get { return icon; }
        set
        {
            icon = value;
            this.Invalidate(); // Redibuja el botón cuando se establece un ícono
        }
    }

    // Propiedad para ajustar el redondeo
    private int borderRadius = 10; // Cambia este valor para ajustar el redondeo (menos redondeado)
    public int BorderRadius
    {
        get { return borderRadius; }
        set
        {
            borderRadius = value;
            this.Invalidate(); // Redibuja el botón cuando se cambia el redondeo
        }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Crear un gráfico para dibujar el botón
        Graphics graphics = pevent.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Crear un rectángulo redondeado
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
        path.AddArc(rect.X + rect.Width - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
        path.AddArc(rect.X + rect.Width - borderRadius, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(rect.X, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);
        path.CloseAllFigures();

        // Rellenar el botón
        graphics.FillPath(new SolidBrush(this.BackColor), path);

        // Dibujar el borde
        Pen pen = new Pen(this.ForeColor, 2);
        graphics.DrawPath(pen, path);

        // Dibujar el ícono si está establecido
        if (icon != null)
        {
            int iconSize = 24; // Tamaño del ícono
            Rectangle iconRect = new Rectangle(
                (rect.Width - iconSize) / 2, // Centrar horizontalmente
                (rect.Height - iconSize) / 3, // Ajustar la posición vertical del ícono
                iconSize,
                iconSize
            );
            graphics.DrawImage(icon, iconRect);
        }

        // Dibujar el texto centrado debajo del ícono
        TextRenderer.DrawText(
            graphics,
            this.Text,
            this.Font,
            new Rectangle(0, rect.Height - 30, rect.Width, 30), // Ajusta la posición del texto
            this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }
}
