using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: DisableRuntimeMarshalling]

namespace color_picker
{
    public partial class MainForm : Form
    {
        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool GetCursorPos(out Point lpPoint);

        [LibraryImport("gdi32.dll")]
        private static partial uint GetPixel(IntPtr hdc, int x, int y);

        public MainForm()
        {
            InitializeComponent();

            KeyPreview = true;
            ShowInTaskbar = true;
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && GetCursorPos(out Point cursorPos))
            {
                using Graphics gfx = Graphics.FromHwnd(IntPtr.Zero);
                IntPtr hdc = gfx.GetHdc();
                uint pixel = GetPixel(hdc, cursorPos.X, cursorPos.Y);

                gfx.ReleaseHdc(hdc);

                int r = (int)(pixel & 0xFF);
                int g = (int)((pixel >> 8) & 0xFF);
                int b = (int)((pixel >> 16) & 0xFF);

                Color color = Color.FromArgb(r, g, b);

                Panel.BackColor = color;
                UpdateColorInfo(color);
            }
        }

        private void Panel_Click(object? sender, EventArgs e)
        {
            using ColorDialog colorDialog = new();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Panel.BackColor = colorDialog.Color;
                UpdateColorInfo(colorDialog.Color);
            }
        }

        private void BtnCopyHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtHex.Text);
        }

        private void BtnCopyRgb_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtRgb.Text);
        }

        private void BtnCopyCmyk_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtCmyk.Text);
        }

        private void BtnCopyHsv_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtHsv.Text);
        }

        private void BtnCopyHsl_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtHsl.Text);
        }

        private void UpdateColorInfo(Color color)
        {
            TxtHex.Text = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

            TxtRgb.Text = $"{color.R}, {color.G}, {color.B}";

            Tuple<float, float, float, float>? cmyk = RgbToCmyk(color);
            TxtCmyk.Text = $"{Math.Round(cmyk.Item1)}%, {Math.Round(cmyk.Item2 * 100)}%, {Math.Round(cmyk.Item3 * 100)}%, {Math.Round(cmyk.Item4 * 100)}%";

            Tuple<float, float, float>? hsv = RgbToHsv(color);
            TxtHsv.Text = $"{Math.Round(hsv.Item1)}°, {Math.Round(hsv.Item2 * 100)}%, {Math.Round(hsv.Item3 * 100)}%";

            Tuple<float, float, float>? hsl = RgbToHsl(color);
            TxtHsl.Text = $"{Math.Round(hsl.Item1)}°, {Math.Round(hsl.Item2 * 100)}%, {Math.Round(hsl.Item3 * 100)}%";
        }

        private static Tuple<float, float, float, float> RgbToCmyk(Color color)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            if (r == 0 && g == 0 && b == 0)
            {
                return Tuple.Create(0f, 0f, 0f, 1f);
            }

            float k = 1 - Math.Max(r, Math.Max(g, b));
            float c = (1 - r - k) / (1 - k);
            float m = (1 - g - k) / (1 - k);
            float y = (1 - b - k) / (1 - k);

            return Tuple.Create(c, m, y, k);
        }

        private static Tuple<float, float, float> RgbToHsv(Color color)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float min = Math.Min(r, Math.Min(g, b));
            float max = Math.Max(r, Math.Max(g, b));
            float delta = max - min;

            if (delta == 0)
            {
                return Tuple.Create(0f, 0f, 0f);
            }

            float h = 0;
            if (delta > 0)
            {
                if (max == r) h = (g - b) / delta;
                else if (max == g) h = (b - r) / delta + 2;
                else if (max == b) h = (r - g) / delta + 4;
                h *= 60;
                if (h < 0) h += 360;
            }

            float s = (max == 0) ? 0 : delta / max;
            float v = max;

            return Tuple.Create(h, s, v);
        }

        private static Tuple<float, float, float> RgbToHsl(Color color)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float min = Math.Min(r, Math.Min(g, b));
            float max = Math.Max(r, Math.Max(g, b));
            float delta = max - min;

            if (delta == 0)
            {
                return Tuple.Create(0f, 0f, 0f);
            }

            float h = 0;
            if (delta > 0)
            {
                if (max == r) h = (g - b) / delta;
                else if (max == g) h = (b - r) / delta + 2;
                else if (max == b) h = (r - g) / delta + 4;
                h *= 60;
                if (h < 0) h += 360;
            }

            float l = (max + min) / 2;
            float s = (max == min) ? 0 : (max - min) / (1 - Math.Abs(2 * l - 1));

            return Tuple.Create(h, s, l);
        }

        private void LnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/joaootdev/color-picker",
                UseShellExecute = true
            });
        }
    }
}
