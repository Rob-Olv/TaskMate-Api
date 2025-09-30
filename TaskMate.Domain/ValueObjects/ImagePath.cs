using System;

namespace TaskMate.Domain
{
    public class ImagePath
    {
        public string Value { get; set; }

        private ImagePath(string value)
        {
            Value = value;
        }

        public static ImagePath Create(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("O caminho não pode ser vazio.");

            if (Uri.TryCreate(value, UriKind.Absolute, out var uri) && 
                (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
            {
                return new ImagePath(value);
            }

            if (System.IO.Path.IsPathRooted(value))
            {
                return new ImagePath(value);
            }

            throw new ArgumentException("Caminho inválido de imagem.");
        }

        public override bool Equals(object obj)
        {
            if (obj is ImagePath other)
                return Value.Equals(other.Value, StringComparison.InvariantCultureIgnoreCase);

            return false;
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value;
    }
}
