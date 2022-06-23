using System;
using System.Linq;

namespace Dream
{
    public class UniqueEmailAddress
    {
        public static void Main(string[] args)
        {
            string[] emailList = Console.ReadLine().Split();
            var emailsCount = emailList.Select(x => new Email(x).ToString()).Distinct().Count();
            Console.WriteLine(emailsCount);
        }
    }

    public class Email
    {
        public string DomainName { get; set; }
        public string LocalName { get; set; }

        public Email(string email)
        {
            var names = email.Split("@");
            if (names.Length!= 2)
                throw new Exception("Invalid email address");
            DomainName = names[1];
            LocalName = names[0];
            if (LocalName.Contains("."))
                LocalName = LocalName.Replace(".", "");
            if(LocalName.Contains("+"))
                LocalName = LocalName.Substring(0, LocalName.IndexOf("+"));
        }

        public override string ToString()
        {
            return $"{this.LocalName}@{this.DomainName}";
        }
    }
}
