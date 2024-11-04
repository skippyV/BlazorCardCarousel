using BlazorCardCarouselTesting.Components.Shared;

namespace BlazorCardCarouselTesting.Components.Pages
{
    public partial class CardCarouselTest
    {
        List<CardCarousel.CardCarouselData> AllCardsData = [];

        protected override void OnInitialized()
        {
            AllCardsData = GetData();
        }

        private List<CardCarousel.CardCarouselData> GetData()
        {
            Console.WriteLine("start CardCarouselTest.GetData");
            // Dummy data here. Data could have been retrieved from file or DB.
            List<CardCarousel.CardCarouselData> data = new List<CardCarousel.CardCarouselData> {
                new CardCarousel.CardCarouselData {
                    ImgDataList = new List<(string path, string caption)>
                    {
                        ("img/turtles/turtle1.png","Turtle One"),
                        ("img/turtles/turtle2.png","Turtle Two"),
                        ("img/turtles/turtle3.jpg","Turtle Three")
                    },
                    CardTitle = "Turtles"
                },
                
                new CardCarousel.CardCarouselData {
                    ImgDataList = new List<(string path, string caption)>
                    {
                        ("img/doggies/dog1.png","Doggie One"),
                        ("img/doggies/dog2.png","Doggie Two"),
                        ("img/doggies/dog3.png","Doggie Three"),
                        ("img/doggies/dog4.png","Doggie Four")
                    },
                    CardTitle = "Doggies"
                },
                
                new CardCarousel.CardCarouselData {
                    ImgDataList = new List<(string path, string caption)>
                    {
                        ("img/tribbles/one_tribble.jpg","Just one tribble"),
                        ("img/tribbles/tribble_inspection.jpg","Interesting"),
                        ("img/tribbles/tribbles_galore.jpg","Population Explosion"),
                        ("img/tribbles/big_tribble.jpg","Big Bully Tribble")
                    },
                    CardTitle = "Tribbles"
                }
            };

            return data;
        }
    }
}