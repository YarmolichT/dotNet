namespace ClassLibrary
{
    public  class AddTimeToUserName
    {

        public  string AddTime(string a)
        {
              var currentDate = DateTime.Now;
              return $"{Environment.NewLine} Hello, {a}, on {currentDate:d} at {currentDate:t}!";
          }
          

     }
}