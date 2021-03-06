namespace MatData.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PhoneNumber { get; set; }

        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        public int MunicipeId { get; set; }
        public Municipe Municipe { get; set; }

        public string UserType { get; set; }
        public string Role {  get; set; }
    }
}
