using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace SimpleBlog.Models
{
    public static class SeedData
    {
        public static void SeedDatabase(BlogDbContext context)
        {
            context.Database.Migrate();
            if(context.BlogPosts.Count() == 0)
            {
                context.BlogPosts.AddRange(
                    new BlogPost
                    {
                        Title = "My first blog post",
                        Content = "Welcome to my first blog post, " +
                            "this is all very exciting",
                        PostedDate = new DateTime()
                    },
                    new BlogPost
                    {
                        Title = "DateTime Now",
                        Content = "I wonder what the difference between" +
                            " DateTime.Now and DateTime.Today is",
                        PostedDate = DateTime.Now
                    },
                    new BlogPost
                    {
                        Title = "DateTime Today",
                        Content = "I wonder what the difference between " +
                            " DateTime.Today and DateTime.Now is",
                        PostedDate = DateTime.Today
                    },
                    new BlogPost
                    {
                        Title = "Lorem ipsum dolor sit amet",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum lacinia ipsum ipsum, vitae placerat arcu laoreet in. Proin id purus maximus, varius nulla sed, pellentesque mi. Proin vitae leo arcu. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec sem mi, aliquam quis odio vel, tincidunt bibendum ipsum. Integer justo neque, dapibus nec imperdiet nec, placerat sed leo. Vivamus sollicitudin justo nec dapibus aliquam. Nam tellus lectus, luctus quis leo id, congue tincidunt urna. Maecenas vel mattis enim."
                            + "Nullam ut nulla nisl.Duis ut hendrerit ligula, sit amet ultrices erat.Proin fermentum elit dolor, nec egestas mi imperdiet quis.Praesent id purus pretium, rhoncus orci ac,"
                            + "ultrices tellus.Praesent dolor mauris, vehicula et condimentum nec, scelerisque vitae ligula.Nullam turpis magna, pulvinar eu iaculis pulvinar,"
                            + "congue et velit.Ut eget diam non augue laoreet fermentum.Donec in imperdiet augue, in consequat massa.Donec nec tristique purus,"
                            + " id venenatis lacus.Nunc quis elit et magna pellentesque varius blandit a sapien. Morbi ut orci tortor.In pellentesque mauris dui,"
                            + "vitae volutpat quam pharetra vel.Duis vel justo massa.Quisque vehicula odio sed justo tristique aliquet.Etiam condimentum sapien eget laoreet bibendum.Phasellus auctor nec tellus id sollicitudin.Fusce dignissim molestie elementum.Pellentesque pellentesque et eros eu rutrum.Vestibulum urna quam,"
                            + "ultricies id massa nec, fringilla pharetra ipsum. Suspendisse imperdiet nisl ac finibus aliquam.Phasellus sit amet venenatis erat.Curabitur et porta dolor.Pellentesque urna lacus",
                        PostedDate = new DateTime(2012, 6, 15, 9, 00, 00)
                    },
                    new BlogPost
                    {
                        Title = "Merry Christmas",
                        Content = "It is christmas",
                        PostedDate = new DateTime(2020, 12, 25, 00, 00, 00)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
