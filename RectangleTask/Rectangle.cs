namespace RectangleTask
{
    public class Rectangle
    {
        private float length = 1;

        private float width = 1;
        public float Length
        {
            get { return length; }
            set { 
                if(value > 0.0f && value <= 20.0f)
                {
                    length = value;
                }
             }
        }

        public float Width
        {
            get { return width; }
            set { 
                if(value > 0.0f && value <= 20.0f)
                {
                    width = value;
                }
             }
        }

        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }
        
        

        public float Perimeter
        {
            get{
                float perimeter = (2 * Length) + (2 * Width);
                return perimeter;
            }
        }

        public float Area
        {
            get{
                float area = Length * Width;
                return area;
            }
        }


    }
}