namespace DesignPatterns.BehavioralPatterns.Memento
{
    public sealed class Originator : ICloneable
    {
        public string? Text { get; private set; } = string.Empty;
        private string? _CursorPosition;
        private string? _Selection;
        private string _CurrentFont;
        private string _Style;
        public Originator(string font, string style, string? text)
        {
            Text = text;
            _CurrentFont = font;
            _Style = style;
        }

        public object Clone()
        {
            return new Originator(_CurrentFont, _Style, Text)
            {
                _CursorPosition = this._CursorPosition,
                _Selection = this._Selection,
                Text = this.Text
            };
        }

        public string SetText(string text, bool overrideText = false)
        {
            if (!overrideText)
            {
                Text += text;
            }
            else
            {
                Text = text;
            }
            return Text;
        }
    }
}