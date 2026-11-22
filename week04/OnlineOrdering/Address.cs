namespace OnlineOrdering;

public class Address
{
    private string _streetAddress;
    private string _city; // i think i should auto-capitalize the first letter
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string ReturnAddress ()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    } 
    
    
}
