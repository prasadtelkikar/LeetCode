using System;
using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class UniqueEmailAddress_II
    {
        public static void Main(string[] args)
        {
            string[] emailList = Console.ReadLine().Split();
            int uniqueCount = FindUniqueEmails(emailList);
            Console.WriteLine(uniqueCount);
        }

        private static int FindUniqueEmails(string[] emailList)
        {
            HashSet<string> uniqueEmails = new HashSet<string>();
            foreach (string email in emailList)
            {
                string processedEmail = ProcessEmails(email);
                uniqueEmails.Add(processedEmail);
            }
            return uniqueEmails.Count;
        }

        private static string ProcessEmails(string email)
        {
            int i = 0;
            StringBuilder localName = new StringBuilder();
            StringBuilder domainName = new StringBuilder();
            bool flag = false;
            while (i < email.Length)
            {
                if (email[i] == '.')
                {
                    i++;
                    continue;
                }
                else if(email[i] == '+')
                {
                    domainName = new StringBuilder();
                    for (int j = email.Length-1; j > i; j--)
                    {
                        if (email[j] == '@')
                        {
                            flag = true;
                            domainName.Append(email[j]);
                            break;
                        }
                        domainName.Append(email[j]);
                    }

                    //Reverse string
                    var reverseArray = domainName.ToString().ToCharArray();
                    Array.Reverse(reverseArray);

                    //Processed email
                    return localName.Append(new string(reverseArray)).ToString();
                }
                else if(email[i] == '@')
                {
                    flag = true;
                    domainName = new StringBuilder();
                    for (int j = i; j < email.Length; j++)
                    {
                        domainName.Append(email[j]);
                    }
                    break;
                }
                else
                {
                    localName.Append(email[i++]);
                }
                if (flag)
                    break;
            }

            return localName.Append(domainName.ToString()).ToString();
        }
    }
}
