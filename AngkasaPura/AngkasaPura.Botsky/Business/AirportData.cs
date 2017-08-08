using AngkasaPura.Botsky.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngkasaPura.Botsky.Business
{
    public class AirportData
    {
        static CosmosDB Data;
        public static CosmosDB Context{
            get
            {
                if (Data == null)
                {
                    Data = new CosmosDB();
                }
                return Data;
            }
        }
        #region Flight
        public static List<Flight> GetFlightByCode(string Code)
        {
            var data = Context.GetDataByQuery<Flight>("Flights",$"SELECT * FROM Flights WHERE Flights.FLIGHT_NO ='{Code}'");
            return data;
        }
        public static List<Flight> GetFlightByAirline(string Airline)
        {
            var data = Context.GetDataByQuery<Flight>("Flights", $"SELECT * FROM Flights WHERE CONTAINS(LOWER(Flights.AIRLINE_NAME),'{Airline.ToLower()}')");
            return data;
        }

        #endregion
    }

    #region entities
    public class Report
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string MS_REPORT_CATEGORY_NAME { get; set; }
        public string MS_SUB_REPORT_CATEGORY_NAME { get; set; }
        public string MS_DETAIL_REPORT_CATEGORY_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string REPORT_DATE { get; set; }
        public string BRANCH_CODE { get; set; }
    }
    public class APTV
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string potrait { get; set; }
        public string content { get; set; }
        public string TITTLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string cover { get; set; }
        public string NAME { get; set; }
        public string BRANCH_NAME { get; set; }
    }
    public class Luggage
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string LONG_NAME { get; set; }
        public string AIRLINE_CODE { get; set; }
        public string FLIGHT_NUM { get; set; }
        public string CodeShare1 { get; set; }
        public string CodeShare2 { get; set; }
        public string CodeShare3 { get; set; }
        public object CodeShare4 { get; set; }
        public object CodeShare5 { get; set; }
        public string EffectiveDate { get; set; }
        public string ETA_TIME_STAMP { get; set; }
        public string STA_TIME_STAMP { get; set; }
        public string AGATE { get; set; }
        public string ARR_SHORT_REM { get; set; }
        public string Purpose { get; set; }
        public string PARKING_STAND { get; set; }
        public string INT_OR_DOM { get; set; }
        public string TERMINAL { get; set; }
        public string ARR_PLANE_NUM { get; set; }
        public string DEP_PLANE_NUM { get; set; }
        public string AIRCRAFT_TYPE { get; set; }
        public string GROUND_HANDLER_CODE { get; set; }
        public string UPLINE_CITY1 { get; set; }
        public string UPLINE_CITY2 { get; set; }
        public string UPLINE_CITY3 { get; set; }
        public string UPLINE_CITY4 { get; set; }
        public string LONG_NAME1 { get; set; }
        public string LONG_NAME2 { get; set; }
        public string LONG_NAME3 { get; set; }
        public object LONG_NAME4 { get; set; }
        public string ACTUAL_CLAIM { get; set; }
        public string STA { get; set; }
        public string RECLAIM_FIRST_BAG_TIME { get; set; }
    }
    public class News
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public int ARTICLE_ID { get; set; }
        public string TITLE_IND { get; set; }
        public string TITLE_ENG { get; set; }
        public string CONTENT_IND { get; set; }
        public string CONTENT_ENG { get; set; }
        public string EVENT_START_DATE { get; set; }
        public string EVENT_END_DATE { get; set; }
        public string BRANCH { get; set; }
        public string CATEGORY_GROUP { get; set; }
        public string DATE_PUBLISH { get; set; }
        public int CATEGORY_ID { get; set; }
        public string CREATED_BY { get; set; }
        public string IMAGES { get; set; }
        public string ATTACHMENT { get; set; }
    }
    public class Facility
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string CATEGORY_NAME_ENG { get; set; }
        public string OBJECT_NAME { get; set; }
        public string OBJECT_PIC { get; set; }
        public string OBJECT_PHONE { get; set; }
        public string OBJECT_HP { get; set; }
        public string OBJECT_ADDRESS { get; set; }
        public string OBJECT_EMAIL { get; set; }
        public string OBJECT_IMAGE { get; set; }
        public string OBJECT_IMAGE1 { get; set; }
        public string OBJECT_DESC_ENG { get; set; }
        public string OBJECT_DESC { get; set; }
    }
    public class Flight
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string AFSKEY { get; set; }
        public string FLIGHT_NO { get; set; }
        public string LEG { get; set; }
        public string LEG_DESCRIPTION { get; set; }
        public string SCHEDULED { get; set; }
        public string ESTIMATED { get; set; }
        public string ACTUAL { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string CATEGORY_NAME { get; set; }
        public string REMARK_CODE { get; set; }
        public string REMARK_DESC_ENG { get; set; }
        public string REMARK_DESC_IND { get; set; }
        public string TERMINAL_ID { get; set; }
        public string GATE_CODE { get; set; }
        public string GATE_OPEN_TIME { get; set; }
        public string GATE_CLOSE_TIME { get; set; }
        public string BAGGAGE_CLAIM_NO { get; set; }
        public string BAGGAGE_CLAIM_OPEN_TIME { get; set; }
        public object BAGGAGE_CLAIM_CLOSE_TIME { get; set; }
        public string STATION1 { get; set; }
        public string STATION1_DESC { get; set; }
        public string STATION2 { get; set; }
        public string STATION2_DESC { get; set; }
        public string STATION3 { get; set; }
        public string STATION3_DESC { get; set; }
        public string STATION4 { get; set; }
        public string STATION4_DESC { get; set; }
        public string STATION5 { get; set; }
        public string STATION5_DESC { get; set; }
        public object STATION6 { get; set; }
        public object STATION6_DESC { get; set; }
        public string AIRLINE_CODE { get; set; }
        public string AIRLINE_NAME { get; set; }
        public string BRANCH_CODE { get; set; }
        public string FR { get; set; }
    }
    #endregion
}