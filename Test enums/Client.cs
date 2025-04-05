
namespace Administratie_Programma
{
    internal class ClientManager
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ClientManager(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public ClientManager()
        {
        }
    }
}
