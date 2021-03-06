﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
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

        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;
            foreach (var item in ratings)
            {
                sum += item;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }

        // zachowania klasy (metody)
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        //public float CalculateAverage()
        //{
        //    float sum = 0;
        //    float avg = 0;
        //    foreach (var item in ratings)
        //    {
        //        sum += item;
        //    }

        //    avg = sum / ratings.Count();

        //    return avg;
        //}

        //public float GiveMaxRating()
        //{
        //    return ratings.Max();
        //}

        //public float GiveMinRating()
        //{
        //    return ratings.Min();
        //}
    }
}
