namespace TP1.Models
{
    public class CustomerMovie
    {
        public Movie movie { set; get; }
        public List<Customer> customerList { set; get; }
        public CustomerMovie(Movie m , List<Customer> c) { 
            movie = m;
            customerList = c;
        }

    }
}
