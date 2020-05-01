using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
{
    class Diary
    { 
        public Diary()
        {
            ratings = new List<float>();
        }

        // gdy nie ma konstruktora
        // stan klasy (zmienne - pola)
        // List<float> ratings = new List<float>();

        // gdy jest konstruktor
        List<float> ratings;

        // zachowania klasy (metody)
        /// <summary>
        /// Dodawanie oceny.
        /// </summary>
        /// <param name="rating">nowa ocena</param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        /// <summary>
        /// Obliczanie średniej  ocen.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Pobieranie najwyższej oceny.
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        /// <summary>
        /// Pobieranie najniższej oceny.
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
