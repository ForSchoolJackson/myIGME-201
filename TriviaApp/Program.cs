using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;

namespace TriviaApp
{
    class TriviaResult
    {
        public string catagory;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int repsonse_code;
        public List<TriviaResult> results;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            //ask user the trivia question
            Console.WriteLine(trivia.results[0].question);

            //create new random
            Random rand = new Random();

            //create list of the answers to randomize
            List<string> answers = new List<string>();
            answers.Add(trivia.results[0].correct_answer);
            answers.AddRange(trivia.results[0].incorrect_answers);

            //sort them randomly
            answers.Sort((a, b) => rand.Next(-1, 2));

            //outputs the trivia results
            int num = 1;
            foreach(var answer in answers)
            {
                Console.WriteLine(num + ". " + answer);
                num++;
            }

            //promts user for answer
            Console.Write("Answer: ");
            Console.ReadLine();

            Console.WriteLine("NGL, you could be right or wrong IDK.");




        }
    }
}
