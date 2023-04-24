using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personal_Project
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        Team2 team; 

        public Window1(Team2 team)
        {
            InitializeComponent();
            this.team = team;
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(team != null)
            {
                tblkTeamName.Text = team.Name;

                if (team.Name == "Arsenal")
                {
                    tblkAdditionalInfo.Text = "Arsenal FC is an English football club based in Islington, London, playing in the Premier League. They have won numerous trophies, including 13 league titles, 14 FA Cups, and one European Cup Winners' Cup. Arsenal was the first club from the South of England to join the Football League in 1893 and have been in the top division for the longest streak, winning the second-most top-flight matches in English football history. Arsenal has had successful periods throughout their history, winning five League Championships and two FA Cups in the 1930s, another FA Cup and two Championships after the war, and five League titles and five FA Cups between 1989 and 2005. Arsène Wenger is the longest-serving manager and won the most trophies, including a record seven FA Cups and a 49-game unbeaten league run in 2003-2004, earning the nickname The Invincibles.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWDNk_vUdDP6pTSv4dmKpqrfkGj-rN2YuQWQ&usqp=CAU"));
                }


                else if(team.Name == "Manchester City")
                {
                    tblkAdditionalInfo.Text = "Manchester City FC is an English football club based in Manchester, playing in the Premier League.They have won eight league titles, six FA Cups, eight League Cups, six FA Community Shields, and one European Cup Winners' Cup. The club was founded in 1880 and has played at the Etihad Stadium since 2003. After winning their first major honour, the FA Cup, in 1904, the club went through a period of decline, culminating in relegation to the third tier in 1998. However, they have remained in the Premier League since 2002-03 and have experienced unprecedented success following the takeover by Sheikh Mansour bin Zayed Al Nahyan in 2008. Under the management of Pep Guardiola, they won the Premier League in the 2017-18 season, achieving 100 points, and completed an unprecedented domestic treble in 2018-19. Manchester City won their third and fourth consecutive Premier League titles in 2020–21 and 2021–22, and reached their first-ever Champions League final in 2021, which they lost to Chelsea.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9Zj6AxpmCFAvpRRs3y-VY97Mfy8D2FUWNiA&usqp=CAU"));
                }

                else if(team.Name == "Newcastle United")
                {
                    tblkAdditionalInfo.Text = "Newcastle United Football Club is an English professional football club based in Newcastle upon Tyne. The club was founded in 1892 by the merger of Newcastle East End and Newcastle West End and currently competes in the Premier League. They play their home matches at St James' Park, which has a capacity of 52,305. The club has won four League titles, six FA Cups and a FA Charity Shield, as well as the 1968–69 Inter-Cities Fairs Cup. Newcastle's most successful period was between 1904 and 1910. They have a long-standing rivalry with nearby Sunderland and wear black-and-white striped shirts, black shorts and black socks.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1Mij_pQ4_NnG4mo1XeoK24k_FLtW-EweX3A&usqp=CAU"));

                }

                else if (team.Name == "Manchester United")
                {
                    tblkAdditionalInfo.Text = "Manchester United, often referred to as Man United, is a professional football club based in Old Trafford, Greater Manchester, England. The club competes in the Premier League and has won a record 20 League titles, 12 FA Cups, and six League Cups. They have also won the European Cup/UEFA Champions League three times, and the UEFA Europa League, the UEFA Cup Winners' Cup, the UEFA Super Cup, the Intercontinental Cup and the FIFA Club World Cup once each. The club's most successful manager was Sir Alex Ferguson, who won 38 trophies, including 13 league titles, five FA Cups, and two Champions League titles between 1986 and 2013. In the 1998–99 season, the club became the first in the history of English football to achieve the European treble of the Premier League, FA Cup, and UEFA Champions League.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS97wE-u9ysmOYjWmI1ay0T7K3PNyq2wFRVw&usqp=CAU"));

                }

                else if (team.Name == "Tottenham Hotspur")
                {
                    tblkAdditionalInfo.Text = "Tottenham Hotspur Football Club, commonly known as Tottenham or Spurs, is a professional football club based in Tottenham, London. It competes in the Premier League and plays home matches at the Tottenham Hotspur Stadium. Founded in 1882, Tottenham has won two league titles, eight FA Cups, four League Cups, and seven FA Community Shields. They were the first club in the 20th century to achieve the League and FA Cup Double and the first British club to win a UEFA club competition. Tottenham has a long-standing rivalry with nearby club Arsenal, with whom they contest the North London derby.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFvOrJYcZ48CwBYNJSkIusWZZIbzEQrEFBtw&usqp=CAU"));

                }

                else if (team.Name == "Aston Villa")
                {
                    tblkAdditionalInfo.Text = "Aston Villa Football Club, commonly referred to as Villa, is a professional football club based in Aston, Birmingham, England. The club competes in the Premier League and has played at their home ground, Villa Park, since 1897. Aston Villa is one of the oldest and most successful clubs in England, having won the Football League First Division seven times, the FA Cup seven times, the League Cup five times, and the European Cup and European (UEFA) Super Cup once. Villa was influential in the sport's move to professionalism in 1885 and was a founding member of both the Football League and the Premier League. The club began its first decline in the mid-1930s, but returned to the elite from the mid-1970s under manager Ron Saunders. Villa won its seventh top-flight league title in 1980–81 and became only the fourth English club to win the European Cup in 1981–82, followed by the European Super Cup in 1982–83. Doug Ellis sold his stake in the club to American billionaire Randy Lerner, whose ownership of the club ended with Villa's first and only relegation from the Premier League in season 2015–16. The club returned to the Premier League in 2019.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgZNyJa7J7s3EKG5ZOEyBEIS4s1q2sGcmbSg&usqp=CAU"));

                }

                else if (team.Name == "Liverpool")
                {
                    tblkAdditionalInfo.Text = "Liverpool Football Club is a professional football club from Liverpool, England that competes in the Premier League. The club was founded in 1892 and has played at Anfield since its formation. Liverpool has won 19 League titles, eight FA Cups, a record nine League Cups, and 16 FA Community Shields domestically. Internationally, the club has won six European Cups, three UEFA Cups, four UEFA Super Cups, and one FIFA Club World Cup. Liverpool established itself as a dominant force in the 1970s and 1980s, winning 11 League titles and four European Cups. Liverpool has long-standing rivalries with Manchester United and Everton and is widely supported worldwide. The club's anthem is \"You'll Never Walk Alone\". The club's supporters have been involved in two major tragedies: the Heysel Stadium disaster in 1985 and the Hillsborough disaster in 1989. Prolonged campaigning for justice saw further investigations that ultimately exonerated the fans.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFDAJ40QBHPNdpA61zwHfu-Z9c0xwadNCsCg&usqp=CAU"));

                }

                else if (team.Name == "Brighton & Hove Albion")
                {
                    tblkAdditionalInfo.Text = "Brighton & Hove Albion Football Club (/ˈbraɪtən ... ˈhoʊv/), commonly referred to simply as Brighton, is an English professional football club based in the city of Brighton and Hove. They compete in the Premier League, the top tier of the English football league system. The club's home ground is the 31,800-capacity Falmer Stadium in Falmer, north east of Brighton. Founded in 1901, and nicknamed the \"Seagulls\" or \"Albion\", Brighton played their early professional football in the Southern League, before being elected to the Football League in 1920. Prior to the current, continuing stint in the Premier League, the club enjoyed greatest prominence between 1979 and 1983 when they played in the First Division and reached the 1983 FA Cup Final, losing to Manchester United after a replay.[2] They were relegated from the First Division in the same season.\r\n\r\nBy the late 1990s, Brighton were in the fourth tier of English football and were having financial difficulties. After narrowly avoiding relegation from the Football League to the Conference in 1997, a boardroom takeover saved the club from liquidation. Successive promotions in 2001 and 2002 brought Brighton back to the second tier, and in 2011, the club moved into the Falmer Stadium after 14 years without a permanent home ground. In the 2016–17 season, Brighton finished second in the EFL Championship and were thus promoted to the Premier League, ending a 34-year absence from the top flight.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXBYe5oErf3lyGQZqwPamSc1qKmRGsRXHnAw&usqp=CAU"));

                }

                else if (team.Name == "Fulham")
                {
                    tblkAdditionalInfo.Text = "Fulham FC is a London-based English professional football club that plays in the Premier League. They have played at Craven Cottage since 1896, except for a two-year period when they played at Loftus Road. Fulham has a rivalry with Chelsea, Queens Park Rangers, and Brentford. They were founded in 1879 and joined the Southern League in 1898. Fulham won two First Division titles, two Second Division titles, and a Western League title. They were elected into the Second Division of the Football League in 1907 and won the Third Division South in 1931-32. Fulham have won two divisional titles and the UEFA Intertoto Cup. They were relegated in 2014, but under new ownership, they have changed divisions in five successive seasons, with the latest being the 2021-22 Championship title win, which promoted them back to the Premier League.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTm7NHqB9_aaLqgKM-DAX3KQ8bqG4o3Liw-3w&usqp=CAU"));

                }

                else if (team.Name == "Brentford")
                {
                    tblkAdditionalInfo.Text = "Brentford FC is a professional football club in Brentford, West London, that competes in the Premier League, having been promoted via the playoffs at the end of the 2020–21 Championship season. Founded in 1889, the club played home games at Griffin Park from 1904 until moving to Gtech Community Stadium in 2020. Their main rivals are Fulham and Queens Park Rangers. Brentford won the Southern League Second Division in 1900–01, were elected to the Football League in 1920, and won the Third Division South title in 1932–33 and the Second Division title in 1934–35. After relegations in the 1960s, the club spent 14 seasons in the Third Division, then won the Third Division title in 1991–92 but were relegated again in 1993. They were relegated to the fourth tier in 1998 and promoted as champions in the 1998–99 campaign. The club were promoted to the Premier League for the first time since 1946–47 by winning the 2021 Championship final.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2PR6313WMrAgR3OxRVs4nPWoTM4OgOgGU7g&usqp=CAU"));

                }

                else if (team.Name == "Chelsea")
                {
                    tblkAdditionalInfo.Text = "Chelsea FC is an English professional football club based in Fulham, West London. They play at Stamford Bridge and compete in the Premier League. The club has won six league titles, eight FA Cups, five League Cups, and four FA Community Shields. Chelsea has won multiple major European competitions, including the Champions League twice and the Club World Cup three times. They have rivalries with Arsenal, Tottenham Hotspur, and Leeds United. As of 2021, Chelsea is the seventh most valuable football club in the world, worth £2.39 billion ($3.2 billion).";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeWu_TI9szjoePbCS4vZ6TrLXKBbqZNVvyvA&usqp=CAU"));

                }

                else if (team.Name == "Crystal Palace")
                {
                    tblkAdditionalInfo.Text = "Crystal Palace Football Club, commonly known as Palace, is a professional football club based in Selhurst, South London, England, competing in the Premier League. The club was formally created as a professional outfit in 1905, but its origins can be traced back to 1861 when an amateur Crystal Palace football team was established. Palace moved to their current home, Selhurst Park, in 1924. They were rejected by the Football League when they first applied for election in 1905 and instead played in the Southern League before eventually joining the Football League in 1920. Palace have spent the majority of their league history competing in the top two tiers of English football and achieved their highest ever league finish of third place in the old First Division in the 1990–91 season. They have also reached two FA Cup finals in 1990 and 2016, finishing runners-up both times.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRrs6AXQdIuhZ6p5KgTaVYpCbUylZplOaUChA&usqp=CAU"));

                }

                else if (team.Name == "West Ham United")
                {
                    tblkAdditionalInfo.Text = "West Ham United Football Club is a professional football team in London that competes in the Premier League. They play at the London Stadium and were founded in 1895 as Thames Ironworks, later becoming West Ham United in 1900. The team has won the FA Cup three times and reached two major European finals. They have never been relegated below the second tier of English football and their highest league finish was third place in the 1985-86 season. The club has a rivalry with Millwall and their team colors are claret and sky blue.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_7TZgt_ZXlxhjC0GlbpgaLXx6stV4ExNY6Q&usqp=CAU"));

                }

                else if (team.Name == "Wolverhampton Wanderers")
                {
                    tblkAdditionalInfo.Text = "Wolverhampton Wanderers Football Club, known as Wolves, is a professional football club based in Wolverhampton, England. They compete in the Premier League and play at Molineux Stadium. Their traditional kit consists of old gold shirts and socks with black shorts, and they have a long-standing rivalry with other clubs from the West Midlands, particularly West Bromwich Albion. Wolves won the FA Cup three times and were English League champions three times. They also won the League Cup twice and the Second Division title three times. The club has had ups and downs, facing financial crisis and relegation multiple times, but they have also experienced a swift turn-around and success. Wolves were instrumental in the launch of the European Cup and reached the quarter-finals of the competition, as well as the semi-finals of the 1960–61 European Cup Winners' Cup and the inaugural UEFA Cup Final in 1972. They reached the UEFA Europa League quarter-finals in 2020 after a 39-year absence from UEFA competitions.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQu0HA8qqGL5VDHabQnI4UJapYetKs22hqRUg&usqp=CAU"));

                }

                else if (team.Name == "AFC Bournemouth")
                {
                    tblkAdditionalInfo.Text = "AFC Bournemouth is a professional football club in Bournemouth, England, competing in the Premier League. They were formed in 1899 as Boscombe and changed their name to AFC Bournemouth in 1971. The club plays at Dean Court and wears red-and-black striped shirts. Bournemouth played in regional leagues before being elected into the Football League in 1923. They won several promotions and titles, including the Championship in 2014-15, and have been in the Premier League for five seasons. Bournemouth were relegated in 2020 but returned in 2022 under the management of Scott Parker.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSab2aBxqe5lVzPM_Cibk4hyME5UdXr4zfVjQ&usqp=CAU"));

                }

                else if (team.Name == "Leeds United")
                {
                    tblkAdditionalInfo.Text = "Leeds United FC is a football club based in Leeds, England, competing in the Premier League and playing at Elland Road. They have won the League Championship three times, four Second Division titles, the FA Cup, EFL Cup, Charity Shield twice, and the Inter-Cities Fairs Cup twice. The team's most successful period was under Don Revie's management in the 1960s and 1970s, winning multiple titles. Leeds United has rivalries with Manchester United and Chelsea, and their kit features white shirts, shorts, and socks with the White Rose of York on their badge.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRq0T8DwgIczV54ZA_suBGJ-OtQT4erEru-PA&usqp=CAU"));

                }

                else if (team.Name == "Leicester City")
                {
                    tblkAdditionalInfo.Text = "Leicester City FC is a professional football club based in Leicester, England, and plays at King Power Stadium in the Premier League. Founded in 1884 as Leicester Fosse, the club moved to Filbert Street in 1891 and became known as Leicester City in 1919. Leicester won the Premier League in 2015-2016 and their highest league finish prior to that was second place in 1928-1929. They have won the FA Cup once in 2021 and the League Cup three times in 1964, 1997, and 2000. The club has played in seven European competitions and reached the UEFA Champions League quarter-finals in 2016-2017 and the UEFA Europa Conference League semi-finals in 2021-2022.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTr5526YBmFV-Eypxe8JLWU6oQzUNMVACyHMw&usqp=CAU"));
                }

                else if (team.Name == "Everton")
                {
                    tblkAdditionalInfo.Text = "Everton FC is a professional football club based in Liverpool, England, and competes in the Premier League. The club was a founding member of the Football League and has spent a record 119 seasons in the top division, missing only four seasons. Everton has won nine league titles, five FA Cups, one European Cup Winners' Cup, and nine Charity Shields. The club's supporters are known as \"Evertonians\" or \"Blues,\" and their main rivals are Liverpool, with whom they contest the Merseyside derby. Everton plays home matches at Goodison Park and wears royal blue shirts with white shorts and socks.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk8E9gTruWG3sZsBQ2iKIiSCMXuGLuRZDpsA&usqp=CAU"));
                }

                else if (team.Name == "Nottingham Forest")
                {
                    tblkAdditionalInfo.Text = "Nottingham Forest FC is an English football club based in West Bridgford, Nottinghamshire, founded in 1865. The club plays at the City Ground and has won two European Cups, one UEFA Super Cup, one League title, two FA Cups, four League Cups, and one FA Charity Shield. The team's most successful period was under the management of Brian Clough and Peter Taylor in the late 1970s and early 1980s, which included back-to-back wins in the European Cup in 1979 and 1980. Forest's fiercest rivalry is with Derby County, with whom they contest the East Midlands derby.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgkI_1GRYMvBcQNv05XdoloOalcr9Sm98QrA&usqp=CAU"));
                }

                else if (team.Name == "Southampton")
                {
                    tblkAdditionalInfo.Text = "Southampton FC is a Premier League football club based in Southampton, Hampshire. They play at St Mary's Stadium and wear red and white shirts. The club was founded in 1885 and has won the Southern League six times. They were promoted to the Football League Third Division in 1920 and reached the First Division in 1965. Southampton won the FA Cup in 1976 as a Second Division team and were runners-up in the League Cup in 1979 and the FA Cup in 2003. The club has a rivalry with Portsmouth and won promotion to the Premier League in 2012 after successive promotions from League One and the Championship.";
                    StadiumImg.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkYyXaJe_SDkLDfWMlfjNH2FVMmOIYGTahXA&usqp=CAU"));
                }

                
            }
        }
    }
}
