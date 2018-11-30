using System;
using System.Data;
using System.Web.Http;
using FixMyOwnTv.DALTableAdapters;

namespace FixMyOwnTv.Controllers
{
    public class RatingController : ApiController
    {
        // POST api/<controller>
        [HttpGet]
        public void Default(string ThisRating)
        {
            if(ThisRating == "5" || ThisRating == "4" ||ThisRating == "3" || ThisRating == "2" || ThisRating == "1")
            {

                DataTable dt = GetRating();
                int RatingCount = (int)dt.Rows[0]["RatingCount"];
                RatingCount += 1;

                decimal SumOfAllRatings = (decimal)dt.Rows[0]["SumOfAllRatings"];
                SumOfAllRatings = SumOfAllRatings + Convert.ToDecimal(ThisRating);

                UpdateRating(RatingCount, SumOfAllRatings);

            }
        }

        private DataTable GetRating()
        {
            RATINGSTableAdapter dta = new RATINGSTableAdapter();
            DataTable dt = new DataTable();
            try
            {
                dt = dta.GetData();
            }
            catch (Exception e)
            {
                string x = e.Message;
            }
            return dt;
        }

        private void UpdateRating(int RatingCount, decimal SumOfAllRatings)
        {
            try
            {
                RATINGSTableAdapter dta = new RATINGSTableAdapter();
                dta.UpdateRatingData(RatingCount, SumOfAllRatings, "FixMyOwnTv");
            }
            catch (Exception e)
            {
                string x = e.Message;
            }
        }
    }
}
