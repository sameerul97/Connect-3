using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace App4
{
    [Activity(Label = "App4", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int activePlayer = 0;
        int[] array = new int[9];
        ImageView image1, image2, image3, image4, image5, image6, image7, image8, image9;
        bool gameactive = true;
        LinearLayout playAgainLayout;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            array = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            playAgainLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout1);

            image1 = FindViewById<ImageView>(Resource.Id.imageView1);
            image2 = FindViewById<ImageView>(Resource.Id.imageView2);
            image3 = FindViewById<ImageView>(Resource.Id.imageView3);
            image4 = FindViewById<ImageView>(Resource.Id.imageView4);
            image5 = FindViewById<ImageView>(Resource.Id.imageView5);
            image6 = FindViewById<ImageView>(Resource.Id.imageView6);
            image7 = FindViewById<ImageView>(Resource.Id.imageView7);
            image8 = FindViewById<ImageView>(Resource.Id.imageView8);
            image9 = FindViewById<ImageView>(Resource.Id.imageView9);
            image1.Click += ImageClicked;
            image2.Click += ImageClicked;
            image3.Click += ImageClicked;
            image4.Click += ImageClicked;
            image5.Click += ImageClicked;
            image6.Click += ImageClicked;
            image7.Click += ImageClicked;
            image8.Click += ImageClicked;
            image9.Click += ImageClicked;
        }
        void ImageClicked(object sender, EventArgs args)
        {
            Console.WriteLine("A: Array0  " + array[0] + " Array:1 " + array[1] + "  Array:2 " + array[2]);
            Console.WriteLine("B: Array3  " + array[3] + " Array:4 " + array[4] + "  Array:5 " + array[5]);
            Console.WriteLine("C: Array6  " + array[6] + " Array:7 " + array[7] + "  Array:8 " + array[8]);

            var image = (ImageView)sender;
            if (array[0]==2 | array[1]==2 | array[3] == 2 | array[4] == 2 | array[5] == 2 | array[6] == 2| array[7] == 2 | array[8] == 2 && gameactive ) { 
            if (activePlayer == 0) {
                if (image == image1)
                {
                    array[0] = activePlayer;
                }
                if (image == image2)
                {
                    array[1] = activePlayer;
                }
                if (image == image3)
                {
                    array[2] = activePlayer;
                }
                if (image == image4)
                {
                    array[3] = activePlayer;
                }
                if (image == image5)
                {
                    array[4] = activePlayer;
                }
                if (image == image6)
                {
                    array[5] = activePlayer;
                }
                if (image == image7)
                {
                    array[6] = activePlayer;
                }
                if (image == image8)
                {
                    array[7] = activePlayer;
                }
                if (image == image9)
                {
                    array[8] = activePlayer;
                }
                image.SetImageResource(Resource.Drawable.pine);
                activePlayer = 1;
            }
            else
            {
                if (image == image1)
                {
                    array[0] = activePlayer;
                }
                if (image == image2)
                {
                    array[1] = activePlayer;
                }
                if (image == image3)
                {
                    array[2] = activePlayer;
                }
                if (image == image4)
                {
                    array[3] = activePlayer;
                }
                if (image == image5)
                {
                    array[4] = activePlayer;
                }
                if (image == image6)
                {
                    array[5] = activePlayer;
                }
                if (image == image7)
                {
                    array[6] = activePlayer;
                }
                if (image == image8)
                {
                    array[7] = activePlayer;
                }
                if (image == image9)
                {
                    array[8] = activePlayer;
                }

                image.SetImageResource(Resource.Drawable.apple);

                activePlayer = 0;
            }
            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += playAgain;
            TextView text = FindViewById<TextView>(Resource.Id.textView1);
            Vibrator v = (Vibrator)this.ApplicationContext.GetSystemService(Context.VibratorService);
            

                if (hasWon() == "Red Won")
            {
                gameactive = false;
                v.Vibrate(200);
                playAgainLayout.Visibility = Android.Views.ViewStates.Visible;
                text.Text = "Red Won";
                


            }
            else if (hasWon() == "Yellow Won")
            {
                gameactive = false;
                v.Vibrate(200);
                playAgainLayout.Visibility = Android.Views.ViewStates.Visible;
                text.Text = "Yello Won";
            }
            else if (hasWon() == "Draw")
            {
                gameactive = false;
                    v.Vibrate(200);
                    playAgainLayout.Visibility = Android.Views.ViewStates.Visible;
                text.Text = "It's a Draw";
            }


        }
        }
        public string hasWon()
        {
            if (array[0] == 1 & array[1] == 1 & array[2] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";

            }
            else if (array[0] == 1 & array[3] == 1 & array[6] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";
            }
            else if (array[2] == 1 & array[5] == 1 & array[8] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";
            }
            else if (array[1] == 1 & array[4] == 1 & array[7] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";
            }
            else if (array[0] == 1 & array[4] == 1 & array[8] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";
            }
            else if (array[2] == 1 & array[4] == 1 & array[6] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";
            }
            else if (array[3] == 1 & array[4] == 1 & array[5] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";
            }
            else if (array[6] == 1 & array[7] == 1 & array[8] == 1)
            {
                Toast.MakeText(this, "Red Won", ToastLength.Long).Show();
                return "Red Won";
            }
            //From NOW its for YELLowWWWWWW #####################
            else if (array[0] == 0 & array[1] == 0 & array[2] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[0] == 0 & array[3] == 0 & array[6] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[2] == 0 & array[5] == 0 & array[8] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[1] == 0 & array[4] == 0 & array[7] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[0] == 0 & array[4] == 0 & array[8] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[2] == 0 & array[4] == 0 & array[6] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[3] == 0 & array[4] == 0 & array[5] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[6] == 0 & array[7] == 0 & array[8] == 0)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Yellow Won";

            }
            else if (array[0] != 2 & array[1] != 2 & array[2] != 2 & array[3] != 2 & array[4] != 2 & array[5] != 2 & array[6] != 2 & array[7] != 2 & array[8] != 2)
            {
                Toast.MakeText(this, "Yellow Won", ToastLength.Long).Show();
                return "Draw";
            }
            return "None";

        }
        public void playAgain(object sender, EventArgs args)
        {
            playAgainLayout.Visibility = Android.Views.ViewStates.Invisible;
            array = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            activePlayer = 0;
            GridLayout gridLayout = FindViewById<GridLayout>(Resource.Id.gridLayout1);
           int count = 0;
            while (count < 9) { 
            ((ImageView)gridLayout.GetChildAt(count)).SetImageResource(0);
                count++;
            }
            gameactive = true;
        }

    }
    
    
}

        


