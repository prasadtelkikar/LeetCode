using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class UniqueEmailAddresses
    {
        public static void Main(string[] args)
        {
            var emailAddresses = Console.ReadLine().Split(',').ToArray();
            int numUniqueEmails = NumUniqueEmails(emailAddresses);
            Console.WriteLine(numUniqueEmails);

        }

        private static int NumUniqueEmails(string[] emailAddresses)
        {
            var separatedEmails = emailAddresses.Select(x => new Emails(x)).Select(y => y.OriginalEmail()).Distinct();
            return separatedEmails.Count();
        }
    }
    public class Emails
    {
        public string LocalName { get; set; }
        public string domainName { get; set; }

        public Emails(string email)
        {
            email = email.Trim();
            var splitted = email.Split('@');
            this.LocalName = splitted[0].Replace(".","");
            int indexOf = this.LocalName.IndexOf('+');
            if(indexOf!=-1)
                this.LocalName = this.LocalName.Substring(0,indexOf);

            this.domainName = splitted[1];
        }
        public string OriginalEmail()
        {
            return $"{this.LocalName}@{this.domainName}";
        }
    }
}
