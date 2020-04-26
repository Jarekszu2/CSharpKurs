using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // stan klasy (zmienne - pola)
        List<float> ratings = new List<float>();

        // zachowania klasy (metody)
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0;
            float avg = 0;
            foreach (var item in ratings)
            {
                sum += item;
            }

            avg = sum / ratings.Count();

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
