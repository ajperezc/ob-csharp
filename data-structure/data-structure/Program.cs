// Exercise 1

Client newClient = new Client(
    "Pepe Botella",
    666999666,
    "Calle Flor, 3",
    "pepe@botella.es",
    true
);

Console.WriteLine(newClient);

public struct Client
{
    public Client(string clientName, int clientPhone, string clientAddress, string clientEmail, bool clientIsNew)
    {
        name = clientName;
        phone = clientPhone;
        address = clientAddress;
        email = clientEmail;
        isNew = clientIsNew;
    }
    
    public string name { get; set; }
    public int phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public bool isNew { get; set; }


    public override string ToString() => $"Name: {name}\nPhone: {phone}\nAddress: {address}" +
                                         $"\nEmail: {email}\nNew?: {isNew}";
}