using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNiliAnswers.Models
{
    public class Person
    {
        public string ImagePath { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private List<Review> _reviews { get; set; } = new List<Review>();
        public List<Review> Reviews
        {
            set
            {
                _reviews = value;
                Rating = _reviews.Average(x => x.Rating);
            }
        }

        private double _rating;
        public double Rating
        {
            get
            {
                return (double)decimal.Round((decimal)_rating, 2, MidpointRounding.AwayFromZero); ;
            }
            set
            {
                _rating = value;
            }
        }

        public void AddReview(Review review)
        {
            _reviews.Add(review);

            Rating = _reviews.Average(x => x.Rating);
        }

        public List<Review> GetReviews()
        {
            return _reviews;
        }

    }
}
