namespace WinFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private List<string> quotes = new List<string>() {
            "The only way to do great work is to love what you do. - Steve Jobs",
            "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
            "In the middle of every difficulty lies opportunity. - Albert Einstein",
            "Believe you can and you're halfway there. - Theodore Roosevelt",
            "The best revenge is massive success. - Frank Sinatra"
        };

        private List<string> randomIdeas = new List<string>() {
            "Start a blog about your favorite hobby.",
            "Learn to play a musical instrument.",
            "Try a new recipe and cook a meal from scratch.",
            "Explore a new hiking trail near your area.",
            "Create a piece of artwork using different mediums.",
            "Read a book from a genre you haven't explored before.",
            "Learn a new programming language.",
            "Start a DIY project at home.",
            "Volunteer at a local charity or organization.",
            "Learn a new dance routine."
        };

        private List<string> exercises = new List<string>() {
            "Do {0} sets of push-ups.",
            "Do {0} sets of squats.",
            "Do {0} sets of planks.",
            "Do {0} sets of lunges.",
            "Do {0} sets of burpees.",
            "Do {0} sets of jumping jacks.",
            "Do {0} sets of mountain climbers.",
            "Do {0} sets of sit-ups.",
            "Do {0} sets of high knees.",
            "Do {0} sets of bicycle crunches."
        };

        private List<string> Challenges = new List<string>() { 

            "Give up social media for a week.",
            "Write a gratitude journal every day for a month.",
            "Meditate for 10 minutes every morning for a week.",
            "Drink 8 glasses of water every day for a week.",
            "Take a cold shower every day for a week.",
            "Read a book a month for a year.",
            "Complete a 30-day fitness challenge.",
            "Learn a new language within six months.",
            "Save a specific amount of money in a year.",
            "Run a 5K race within three months."
        };

        private Random random = new Random();       
        public Form1()
        {
            InitializeComponent();
        }       

        private void btnQuote_Click(object sender, EventArgs e)
        {
            if (quotes.Count>0)
            {
                int index = random.Next(0,quotes.Count);
                string quote = quotes[index];
                MessageBox.Show(quote);
                quotes.Remove(quote);
            }
            else
            {
                MessageBox.Show("No more quotes available.");
            }
        }

        private void btnRandomIdea_Click(object sender, EventArgs e)
        {
            if (randomIdeas.Count>0)
            {
                int index = random.Next(randomIdeas.Count);
                string randomIdea = randomIdeas[index];
                MessageBox.Show("Random Idea:\n\n" + randomIdea);
                randomIdeas.Remove(randomIdea);
            }
            else
            {
                MessageBox.Show("No more random ideas available.");
            }
        }

        private void btnExercise_Click(object sender, EventArgs e)
        {
            if (exercises.Count>0)
            {
                int index = random.Next(0,exercises.Count);
                int sets = random.Next(3, 6);
                string exercise = string.Format(exercises[index], sets);
                MessageBox.Show(exercise);
                exercises.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("No more exercises available.");
            }
        }

        private void btnChallenge_Click(object sender, EventArgs e)
        {
            if (Challenges.Count>0)
            {
                int index = random.Next(0,Challenges.Count);
                string challenge = Challenges[index];
                MessageBox.Show(challenge);
                Challenges.Remove(challenge);
            }
            else
            {
                MessageBox.Show("No more challenges available.");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Welcome to Random Things To Do or RTTD for short!");

            
        }
    }
}
