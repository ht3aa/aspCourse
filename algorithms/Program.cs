namespace Algorithms;

class Program
{
  public static void Main()
  {

    string[] names = new string[]
     {
            "Aaron", "Abigail", "Adam", "Adrian", "Aiden", "Alex", "Alexa", "Alexander",
            "Alexis", "Alice", "Alicia", "Alison", "Amanda", "Amber", "Amy", "Andrea",
            "Andrew", "Angela", "Anna", "Anthony", "Ashley", "Austin", "Ava", "Barbara",
            "Benjamin", "Betty", "Blake", "Brandon", "Brenda", "Brian", "Brittany", "Brooke",
            "Bryan", "Caleb", "Cameron", "Carl", "Carla", "Carol", "Caroline", "Carter",
            "Catherine", "Charles", "Charlotte", "Chloe", "Chris", "Christian", "Christina",
            "Christopher", "Cindy", "Claire", "Clara", "Connor", "Crystal", "Cynthia",
            "Daniel", "David", "Dawn", "Deborah", "Dennis", "Diana", "Diane", "Donna",
            "Doris", "Dorothy", "Douglas", "Dylan", "Edward", "Eleanor", "Elizabeth",
            "Emily", "Emma", "Eric", "Ethan", "Eugene", "Evan", "Evelyn", "Faith",
            "Florence", "Frances", "Frank", "Gabriel", "Gavin", "George", "Gloria",
            "Grace", "Gregory", "Hannah", "Harold", "Heather", "Helen", "Henry", "Isaac",
            "Isabella", "Jack", "Jacob", "James", "Jamie", "Jane", "Janet", "Janice",
            "Jason", "Jean", "Jeffrey", "Jennifer", "Jessica", "John", "Jonathan", "Joseph",
            "Joshua", "Judith", "Judy", "Julia", "Julie", "Justin", "Katherine", "Kathleen",
            "Kayla", "Keith", "Kelly", "Kenneth", "Kevin", "Kimberly", "Kyle", "Laura",
            "Lauren", "Lillian", "Lily", "Linda", "Logan", "Lori", "Lucas", "Luke"
     };

    Console.WriteLine(BinarySearch.Run(names, "Lily"));
  }
}
