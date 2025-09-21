namespace ShelteredDaughter.Models
{
    public class Piece
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        // CSSの定義名を利用するので文字列
        public string ColorClass { get; set; }

        public Piece(string name, int x, int y, int w, int h, string colorClass = "piece-default")
        {
            Name = name;
            X = x;
            Y = y;
            Width = w;
            Height = h;
            ColorClass = colorClass;
        }
    }
}
