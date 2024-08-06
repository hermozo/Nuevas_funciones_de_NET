using Newtonsoft.Json;


namespace Json_NET_App
{
    internal class Program
    {
        private static string _path = @"Contacts.json";

        static void Main(string[] args)
        {
            var list = GetContacts();

            // Serializa y crear un file

            string jsonContacts = JsonConvert.SerializeObject(list.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, jsonContacts);

            // Deserealizar file 
            using (var reader = new StreamReader(_path))
            {
                var contentFile = reader.ReadToEnd();
                var data = JsonConvert.DeserializeObject<List<Contact>>(contentFile);
                Console.WriteLine(string.Format("Nombre {0}", data[0].Name));
            }
        }

        public static List<Contact> GetContacts()
        {
            List<Contact> list = new List<Contact>()
            {
                new Contact()
                {
                    Name = "MIguel",
                    Adress = new Adress
                    {
                        Street = "Periferica",
                        City = new City{
                            Name = "La pAz",
                            Country = new Country
                            {
                                Name = "Bolivia",
                                Code = 45454
                            }
                        }
                    },
                    Phones = new List<Phone> {
                        new Phone()
                        {
                            Name = "Personal",
                            PhoneNumber = "4545455"
                        },
                        new Phone()
                        {
                            Name = "Casa",
                            PhoneNumber = "4444545455"
                        },
                    }
                },
                new Contact()
                {
                    Name = "Angel",
                    Adress = new Adress
                    {
                        Street = "Villa FAtima",
                        City = new City{
                            Name = "La pAz",
                            Country = new Country
                            {
                                Name = "Bolivia",
                                Code = 45454
                            }
                        }
                    },
                    Phones = new List<Phone> {
                        new Phone()
                        {
                            Name = "Personal",
                            PhoneNumber = "12312312"
                        },
                        new Phone()
                        {
                            Name = "Casa",
                            PhoneNumber = "56767687"
                        },
                    }
                },
                new Contact()
                {
                    Name = "Hermozo",
                    Adress = new Adress
                    {
                        Street = "Villa FAtima",
                        City = new City{
                            Name = "La pAz",
                            Country = new Country
                            {
                                Name = "Bolivia",
                                Code = 45454
                            }
                        }
                    },
                    Phones = new List<Phone> {
                        new Phone()
                        {
                            Name = "Personal",
                            PhoneNumber = "23432324"
                        },
                        new Phone()
                        {
                            Name = "Casa",
                            PhoneNumber = "4565654"
                        },
                    }
                }
            };
            return list;
        }
    }
}
