namespace Learningcsharp;

public class User
{

    public User(string fName, string lName)
    {
        FirstName = fName;
        _LastName = lName;

        _score = 0;

    }

    public string FirstName { get; set; }

    public string _LastName { get; set; }

    public string lastname {
        get
        {
            return _LastName;
        }
        set
        {
            _LastName = value;
        }
    }
    
        

    private int _score;

    public int Score {
        get
        {
            return _score;
        }
        set
        {
            if (value > 100)
            {
                _score = 100;
            } else if (value < 0)
            {
                _score = 0;
            }
            else
            {
                _score = value;
            }
        }
    }

}
    
    
   