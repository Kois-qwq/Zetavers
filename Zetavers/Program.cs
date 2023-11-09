using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zetavers
{
    public static class Program
    {
        #if DEBUG
        private const string Base_Game_Name = @"Zetavers-Development";
        #else
        private const string Base_Game_Name = @"Zetavers";
        #endif

        public static Form x = new Form();
        public static Label Title = new Label();
        public static Label Label_x = new Label();
        public static Button Button_Play = new Button();
        public static Button Button_Exit = new Button();
        public static int StoryProgress = 0;
        public static int Chapter = 0;
        public static bool InStory = false;

        [STAThread]
        public static void Main()
        {
            

            x.Text = Base_Game_Name;
            x.Size = new Size(1920, 1080);
            x.Icon = new Icon("Resources/Zetavers.ico");
            x.FormBorderStyle = FormBorderStyle.None;
            x.WindowState = FormWindowState.Maximized;
            x.BackgroundImage = Image.FromFile("Resources/Rainbow.png");
            x.BackgroundImageLayout = ImageLayout.Zoom;
            x.KeyPreview = true;
            x.KeyDown += Form_KeyDown;
            x.MouseClick += Form_MouseClick;

            int Form_CenterX = x.ClientSize.Width / 2;
            int Form_CenterY = x.ClientSize.Height / 2;

            Title.Text = Base_Game_Name;
            Button_Play.Text = "Play";
            Button_Exit.Text = "Exit";

            Title.Location = new Point(Form_CenterX - Title.Width / 2, 0);
            Label_x.Location = new Point(180, 600);
            Button_Play.Location = new Point(Form_CenterX - Button_Play.Size.Width / 2, Form_CenterY - Button_Play.Size.Height / 2 - Button_Play.Size.Height / 2);
            Button_Exit.Location = new Point(Form_CenterX - Button_Exit.Size.Width / 2, Form_CenterY - Button_Exit.Size.Height / 2 + Button_Exit.Size.Height / 2);

            Title.Size = new Size(130, 20);
            Label_x.Size = new Size(1200, 200);

            Button_Play.Click += new EventHandler(Click_Play);
            Button_Exit.Click += new EventHandler(Exit);

            x.Controls.Add(Title);
            x.Controls.Add(Button_Play);
            x.Controls.Add(Button_Exit);

            Application.Run(x);
        }
        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.Space)
            {
                if (InStory == true)
                {
                    StoryProgress++;
                    LoadDialogue();
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (InStory == true)
                {
                    StoryProgress++;
                    LoadDialogue();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                if (InStory == true)
                {
                    if (StoryProgress != 0)
                    {
                        StoryProgress--;
                        LoadDialogue();
                    }
                }
            }
        }
        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (InStory == true)
                {
                    StoryProgress++;
                    LoadDialogue();
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (InStory == true)
                {
                    if (StoryProgress != 0)
                    {
                        StoryProgress--;
                        LoadDialogue();
                    }
                }
            }
        }
        private static void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private static void Click_Play(object sender, EventArgs e)
        {
            if (Chapter == 0)
            {
                InitializeStory();
            }
        }
        private static void InitializeStory()
        {
            x.Controls.Remove(Title);
            x.Controls.Remove(Button_Play);
            x.Controls.Remove(Button_Exit);
            x.Controls.Add(Label_x);
            StoryProgress = 0;
            InStory = true;
            LoadDialogue();
        }
        private static void LoadDialogue()
        {
            if (Chapter == 0)
            {
                string dialogue = Ch0_Story(StoryProgress);
                Label_x.Text = dialogue;
            }
        }
        private static string Ch0_Story(int progress)
        {
            switch (progress)
            {
                case 0:
                    return "You have no way of peeking into that chaotic world.";
                case 1:
                    return "Originally, it was just an inconspicuous, very common thing, fleeting.";
                case 2:
                    return "But a time and space is given new life, and the gears of destiny are driven...";
                case 3:
                    return "The story is born from this.";
                case 4:
                    return "System: The following contents are all from files kept by *****; encryption level: S+; decryption integrity is 98%";
                case 5:
                    return "System: Time and space No. 073101: **(undecipherable) year ****, March 13 xx noon xx pm";
                case 6:
                    return "On the 13th, a young mother collided with a small blue aircraft on the streets of Dongsanzixing and was sent to Sanzixing Hospital for emergency treatment on xx:xx.";
                case 7:
                    return "On the 14th, the patient was still in a coma and all physical indicators were in good condition.";
                case 8:
                    return "Information monitored: Name: Akami; Age: 8 years old; Relationship to patient: daughter";
                case 9:
                    return "Akami: Mom? (No response) Mom? Wake up! (No response)";
                case 10:
                    return "The young girl had been at her mother's bedside for three days and three nights, calling for her mother in every possible way...";
                case 11:
                    return "On the morning of the third day, Akami finally chose to stay quietly with his mother, without trying to wake her up or leaving.";
                case 12:
                    return "Another 4 days later...";
                case 13:
                    return "In the early morning, Akami was still sleeping soundly next to her mother's bed, when a cold wind blew in from the half-open window.";
                case 14:
                    return "The mother, who had been in a coma for seven days, opened her eyes for the first time. Whether it was a coincidence, Akami also woke up shivering from the cold wind.";
                case 15:
                    return "Akami looked up and saw her mother waking up.";
                case 16:
                    return "Akami: Mom! You finally woke up!";
                case 17:
                    return "Mother: Am I in... the hospital?";
                case 18:
                    return "Akami: Mom, I'm so scared. I'm afraid you'll never wake up again...";
                case 19:
                    return "Akami almost cried, but she tried her best to hold it in and told her the reason for her coma.";
                case 20:
                    return "Akami: Mom, please promise me not to sleep again, ugh.";
                case 21:
                    return "Mother (smiling softly): It's okay, the matter is over";
                case 22:
                    return "Two weeks later...";
                case 23:
                    return "After her mother recovered, Akami, even though she was young, was keenly aware that her mother had become a different person since she woke up. The tired mother who had no smile all day long disappeared. Now she puts a smile on her face every day. face. In particular, Akami's mother was obsessed with music. However, Akami prefers her current mother.";
                case 24:
                    return "There was also a reason for her mother's previous pessimism.";
                case 25:
                    return "A long time ago";
                case 26:
                    return "Akami was born on a rainy day in **** year, in the evening, When the mother successfully gave birth to Akami, she was so excited that she had her first child. She made up her mind at that time to make this child grow up healthily and happily.";
                case 27:
                    return "However, the cruelty of reality made her hit rock bottom. . .";
                case 28:
                    return "When Akami was five years old, one day she had an unbearable headache. Her mother was so worried that she took her to the hospital for examination. After Akami's symptoms subsided, a doctor pulled her aside and told her that after examination, Akami was suffering from the disease. There is a congenital genetic defect on the surface. She is just like any other child, but because the disease is incurable and fatal, she can only live until she is 17 years old.";
                case 29:
                    return "The mother's heart suddenly sank to the bottom of the lake. She wanted to see Akami grow up healthy and happy, but Akami would leave her at the age of 17. Because of this, she has been in a negative state for a long time. ";
                case 30:
                    return "Time returns to now, After her mother woke up, she would sometimes murmur that she had gone to a magical world, and would even try to describe it to Akami. However, her descriptions were vague. Akami only knew that she went to a new world, but she didn't quite believe it.";
                case 31:
                    return "In the blink of an eye, Akami grew up a lot. Although the disease recurred many times and was not life-threatening, it also made her legs unsafe. When she was 12 years old, Akami gradually fell in love with music and was exposed to the beauty of the online world. She even fell in love with music games, which became an obsession for her.";
                case 32:
                    return "As a result, Akami became a moderate two-dimensional and sound traveler. Her mother observed Akami's changes and didn't say anything. She just spent more time and frequency with Akami. She knew that Akami's days were numbered. . .";
                case 33:
                    return "In the days that followed, Akami would often ask her mother to buy some peripherals and signboards. She felt very happy that she had a mother who understood her.";
                case 34:
                    return "Unknowingly, Akami grew up to 15 years old";
                case 35:
                    return "End of the Chatper 0.";
                case 36:
                    x.Controls.Add(Title);
                    x.Controls.Add(Button_Play);
                    x.Controls.Add(Button_Exit);
                    x.Controls.Remove(Label_x);
                    StoryProgress = 0;
                    Chapter = 1;
                    InStory = false;
                    return "";
                default:
                    return "";
            }
        }
    }
}