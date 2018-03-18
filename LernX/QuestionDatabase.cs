using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.IO;

namespace LernX {
	static class QuestionDatabase {
        
		public class QuestionList {
			Dictionary<string, List<Question>> questions = new Dictionary<string, List<Question>>();

			public void AddChapter(string chapter, IEnumerable<Question> questions = null) {
				this.questions.Add(chapter, new List<Question>(questions ?? new Question[0]));
			}

			public void AddQuestion(string chapter, Question question) {
				if (!questions.ContainsKey(chapter))
					AddChapter(chapter);

				questions[chapter].Add(question);
			}

			public void Shuffle(string chapter) {
				questions[chapter].OrderBy(o => new Guid());
			}

			public List<Question> this[string i] {
				get {
					return questions[i];
				}
				set {
					questions[i] = value;
				}
			}

			public string[] GetChapters() {
				return questions.Keys.Reverse().ToArray();
			}
			public bool ChapterExist(string name) {
				return questions.ContainsKey(name);
			}

            public XElement Save() {
                XElement l = new XElement("theme");

                foreach (var p in questions) {
                    XElement item = new XElement("chapter");
                    item.Add(new XAttribute("name", p.Key));

                    foreach (var i in p.Value) {
                        var q = new XElement("question");
                        q.Add(i.ToString());
                        q.Add(new XAttribute("type", i.GetType().ToString()));
                        q.Add(new XAttribute("name", i.name));
                        item.Add(q);
                    }
                    l.Add(item);
                }

                return l;
            }

            public QuestionList Load(XElement baseTheme)
            {
                //XElement l = new XElement("theme");
                questions = new Dictionary<string, List<Question>>();
                
                foreach (var chapter in baseTheme.Descendants())
                {
                    if (chapter.Parent != baseTheme)
                        continue;
                    //new XElement("chapter");
                    //chapter.Add(new XAttribute("name", p.Key));
                    string cName = chapter.Attribute("name").Value;

                    var list = new List<Question>();
                    foreach (var i in chapter.Descendants())
                    {
                        Question q = (Question)Activator.CreateInstance("LernX", i.Attribute("type").Value).Unwrap();
                        //var q = new XElement("question");
                        q.name = i.Attribute("name").Value;
                        q.Load(i.Value);
                        list.Add(q);
                    }

                    questions.Add(cName, list);
                }

                return this;
            }
        }

		static Dictionary<string, QuestionList> questions = new Dictionary<string, QuestionList>();

        public static bool saveOnAddition = true;

        static QuestionDatabase() {
            LoadDatabase();
        }

		public static void Shuffle(string theme, string chapter) {
			questions[theme].Shuffle(chapter);
		}

		/// <summary>
		/// Gets a Queue filled with Question from the given theme
		/// </summary>
		/// <param name="theme">The name of the theme of question</param>
		/// <param name="amount">The amount of question, if -1 return all</param>
		/// <param name="shuffle">If true, the list of question will be random</param>
		/// <param name="start">The start of the range of question, if -1 it will be asigned a random value</param>
		/// <returns></returns>
		public static List<Question> GetQuestions(string theme, string chapter, int amount = -1, int start = -1, bool shuffle = false) {
			amount = (amount == -1 || amount > questions[theme][chapter].Count) ? questions[theme][chapter].Count : amount;
			start = (start == -1 ? new Random().Next(0, questions[theme][chapter].Count - amount) : start);
			//if(amount > question[theme].Count)
			//throw (new ArgumentOutOfRangeException($"There are not {amount} question(s), there are only {question[theme].Count}"));

			if (shuffle)
				Shuffle(theme, chapter);

			return questions[theme][chapter].GetRange(start, amount);
		}

		public static void AddTheme(string name) {
			if (name == "")
				return;

			questions.Add(name, new QuestionList());
            
            if (saveOnAddition)
                SaveDatabase();
		}
		public static void AddChapter(string theme, string name) {
			if (name == "")
				return;

			questions[theme].AddChapter(name);
            if (saveOnAddition)
                SaveDatabase();
        }

		public static void AddQuestion(string theme, string chapter, Question question) {
            if (question == null)
                return;

			if (!ChapterExist(theme, chapter))
				AddChapter(theme, chapter);

			questions[theme].AddQuestion(chapter, question);
            if (saveOnAddition)
                SaveDatabase();

        }

		public static bool ChapterExist(string theme, string name) {
			return questions[theme].ChapterExist(name);
		}
		public static bool ThemeExist(string name) {
			return questions.ContainsKey(name);
		}

		public static string[] GetThemes() {
			return questions.Keys.Reverse().ToArray();
		}
		public static string[] GetChapters(string theme) {
			return questions[theme].GetChapters();
		}

		public static void Clear() {
			questions = new Dictionary<string, QuestionList>();
		}

        public static void SaveDatabase() {
            XElement root = new XElement("root");

            //XElement l = new XElement("questionLists");
            //root.Add(l);
            foreach(var p in questions) {
                XElement item = p.Value.Save();
                item.Add(new XAttribute("name", p.Key));
                

                root.Add(item);
            }


            root.Save("database.xml");
        }

        public static void LoadDatabase()
        {
			try {
				XElement root = XElement.Load("database.xml");

				questions = new Dictionary<string, QuestionList>();

				//XElement l = new XElement("questionLists");
				//root.Add(l);
				/*foreach (var p in questions)
				{
					XElement item = p.Value.Save();
					item.Add(new XAttribute("name", p.Key));


					root.Add(item);
				}*/
				foreach (var theme in root.Descendants()) {
					if (theme.Parent != root)
						continue;
					questions.Add(theme.Attribute("name").Value, new QuestionList().Load(theme));
				}

				root.Save("database.xml");
			}catch (FileNotFoundException e) {
				questions = new Dictionary<string, QuestionList>();
			}
        }
    }
}
