using System;

namespace TaskMate.Domain
{
    public class Email
    {
        public string Value { get; set; }

        private Email(string value)
        {
            Value = value;
        }

        public static Email Create(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Email não pode ser vazio.");

            if (!value.Contains("@"))
                throw new ArgumentException("Email inválido");

            return new Email(value);
        }

        public override bool Equals(object obj)
        {
            if (obj is Email email)
                return Value.Equals(email.Value, StringComparison.InvariantCultureIgnoreCase);

            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString() => Value;
    }
}
