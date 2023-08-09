namespace DogsMvc.Models
{
    public class DataService
    {

        public List<Dog> dogList;

        public DataService()
        {
            dogList = new List<Dog>();
           
        }

        public void AddDog(Dog dog)
        {
            dogList.Add(dog);
        }

        public Dog[] GetAllDogs()
        {
            return dogList.ToArray();
        }

        public Dog GetDogById(int id)
        {
            return dogList.Find(d => d.Id == id);
        }
    }
}
