Dictionary<char, int> stat = new Dictionary<char, int>();

            foreach (string line in lines)
            {
                string cleaned = line.Replace(" ","");

                foreach (char letter in cleaned)
                {
                    if (stat.ContainsKey(letter))
                    {
                        stat[letter]++;
                    }
                    else
                    {
                        stat.Add(letter, 1);
                    }
                }

            }

            StreamWriter s = new StreamWriter("stat.txt", false, Encoding.UTF8);

            foreach (var item in stat)
            {
                s.WriteLine($"{item.Key}\t{item.Value}");
            }
            s.Close();
