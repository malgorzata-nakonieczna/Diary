using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klasy
{
    class Diary
    {
        //dane
        List<float> ratings;  //zadeklarowanie listy ocen

        //zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating); //metoda dodaje oceny do listy ocen
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum = sum + rating;

            }
            avg = sum / ratings.Count;
            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
