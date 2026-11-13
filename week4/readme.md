📘 Chapter 4: Loops, Files, and Random Numbers (Visual C#)

Kani waa sharraxaad dhammaystiran oo ku saabsan cutubka Loops, Files, and Random Numbers ee luqadda Visual C# (buugga Starting Out with Visual C# ee Tony Gaddis). Cutubkan waxaan ku baranaynaa sida koodhka loogu celceliyo (Loops), sida xogta loogu kaydiyo loogana akhriyo faylasha (Files), iyo sida loo soo saaro tirooyin bakhtiyaa-nasiib ah (Random Numbers).

📋 Mowduucyada Cutubka (Topics)

5.1 The while Loop

5.2 The ++ and -- Operators (Increment & Decrement)

5.3 The for Loop

5.4 The do-while Loop

5.5 Using Files for Data Storage (Kaydinta & Akhrinta Faylasha)

5.6 The OpenFileDialog and SaveFileDialog Controls

5.7 Random Numbers (Tirooyinka Bakhtiyaa-nasiibka)

5.8 The Load Event

5.1 The while Loop

while loop wuxuu sababaa in hal statement ama koox statements ah ay ku celceliyaan inta shuruudda (Boolean expression) ay tahay run (true).

Qaabka Guud (Syntax):

while (BooleanExpression)
{
    // Koodhkan wuxuu ku celcelinayaa inta BooleanExpression uu run yahay
}


Astaamaha Muhiimka ah ee while Loop:

Pretest Loop: Wuxuu marka hore hubiyaa shuruudda ka hor intaanu fulin koodhka gudaha ku jira. Haddii shuruuddu bilowgaba been (false) tahay, loop-ku marnaba ma shaqaynayo.

Iteration: Mar kasta oo loop-ku fuliyo koodhkiisa waxaa loo yaqaan hal iteration.

Counter Variable: Waa doorsoome loo isticmaalo in lagu tiriyo inta jeer ee loop-ku shaqeeyay.

Infinite Loop: Waa loop aan waligiis istaagin haddii la ilaawo in la beddelo doorsoomaha shuruudda been ka dhigaya (sida count++).

Tusaale (while loop):

int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1; // Wuxuu kordhinayaa count si loop-ku u istaago marka uu 5 gaaro
}


🧪 Practice Lab: Ending Balance Calculator

Tusaalahan wuxuu xisaabinayaa lacagta kuu soo baxaysa bil kasta (oo lagu daray dulsaar/interest 0.5% ah) iyadoo la isticmaalayo while loop, natiijadana lagu darayo ListBox:

const decimal INTEREST_RATE = 0.005m; // 0.5% dulsaar bishii
decimal balance = decimal.Parse(startingBalTextBox.Text);
int months = int.Parse(monthsTextBox.Text);
int count = 1;

while (count <= months)
{
    // Ku dar dulsaarka bishan
    balance = balance + (INTEREST_RATE * balance);

    // Ku soo bandhig ListBox-ka
    detailListBox.Items.Add("The ending balance for month " + count + " is " + balance.ToString("c"));

    count++;
}

endingBalanceLabel.Text = balance.ToString("c");


5.2 The ++ and -- Operators

Increment (++): Wuxuu qiimaha doorsoomaha ku daraa 1 (tusaale: count++; oo la mid ah count += 1; ama count = count + 1;).

Decrement (--): Wuxuu qiimaha doorsoomaha ka jaraa 1 (tusaale: count--; oo la mid ah count -= 1; ama count = count - 1;).

Postfix Mode vs. Prefix Mode:

Postfix (count++): Marka hore wuxuu isticmaalaa qiimaha hadda jira, ka dib ayuu kordhiyaa 1.

int count = 5;
int x = count++; // x wuxuu noqonayaa 5, count-na wuxuu noqonayaa 6


Prefix (++count): Marka hore wuxuu kordhiyaa 1, ka dib ayuu isticmaalaa qiimaha cusub.

int count = 5;
int x = ++count; // count wuxuu noqonayaa 6, x-na wuxuu noqonayaa 6


5.3 The for Loop

for loop waxaa si gaar ah loogu talagalay xaaladaha loo baahan yahay counter variable maamula inta jeer ee loop-ku shaqaynayo. Waa Pretest Loop wuxuuna leeyahay saddex qaybood:

Initialization: Meesha laga bilaabayo tirinta (hal mar ayay shaqaysaa).

Test: Shuruudda la hubinayo mar kasta.

Update: Kordhinta ama dhimista tiriyaha (counter).

Qaabka Guud (Syntax):

for (InitializationExpression; TestExpression; UpdateExpression)
{
    // statements
}


Tusaalooyin (for loop):

// 1. Ku celcelin 5 jeer
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}

// 2. Kordhin 10-10 ah (0 ilaa 100)
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

// 3. Dib u tirin (10 ilaa 0)
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}


🧪 Practice Lab: The Squares Application

for (int number = 1; number <= 10; number++)
{
    int square = number * number;
    outputListBox.Items.Add("The square of " + number + " is " + square);
}


5.4 The do-while Loop

do-while loop waa Posttest Loop, taas oo macnaheedu yahay inuu marka hore fuliyo koodhka ugu yaraan hal mar ka hor intaanu hubin shuruudda (BooleanExpression).

Qaabka Guud (Syntax):

do
{
    // statements
} while (BooleanExpression);


Farqiga while iyo do-while:

int number = 1;

// do-while: Wuxuu soo saarayaa MessageBox hal mar xitaa haddii shuruuddu been tahay
do
{
    MessageBox.Show(number.ToString());
} while (number < 0);

// while: Waxba ma soo saarayo sababtoo ah shuruuddu bilowgaba waa been
while (number < 0)
{
    MessageBox.Show(number.ToString());
}


5.5 Using Files for Data Storage

Marka barnaamijku u baahdo inuu xog kaydiyo si hadhow loo isticmaalo, wuxuu ku qoraa fayl (Text File). Waxaa jira 3 tallaabo oo joogto ah:

Open the file: Xiriir u samee barnaamijka iyo faylka.

Process the file: Ku qor xog ama ka akhri xog.

Close the file: Xir xiriirka faylka (Close()).

(Fiiro gaar ah: Si aad u isticmaasho faylasha, ku dar using System.IO; koodhkaaga sare).

1. Qorista Xogta (Writing Data - StreamWriter)

File.CreateText("magaca.txt"): Wuxuu abuuraa fayl cusub. Haddii uu horay u jiray, wuu tirtiraa wixii ku jiray.

File.AppendText("magaca.txt"): Wuxuu furaa fayl horay u jiray isagoon tirtirin xogtii ku jirtay, wuxuuna ku daraa xog cusub dhammaadka.

WriteLine() vs Write(): WriteLine wuxuu qoraa xogta wuxuuna u degaa sadar cusub (newline), halka Write uu isku xijiyo isagoon sadar cusub u degin.

StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");
outputFile.Close();

// Ku darista xog iyadoo aan la tirtirin tii hore (AppendText)
StreamWriter appendFile = File.AppendText(@"C:\Data\Names.txt");
appendFile.WriteLine("Lynn");
appendFile.WriteLine("Jamal");
appendFile.Close();


2. Akhrinta Xogta (Reading Data - StreamReader)

Waxaa loo isticmaalaa File.OpenText() iyo StreamReader:

ReadLine(): Wuxuu akhriyaa hal sadar oo kaliya.

ReadToEnd(): Wuxuu akhriyaa dhammaan waxa faylka ku jira hal mar.

Read(): Wuxuu akhriyaa hal xaraf (character) oo kaliya.

File.ReadAllText("faylka.txt"): Wuxuu si toos ah u soo akhriyaa dhammaan qoraalka faylka.

Akhrinta Faylka oo dhan iyadoo la isticmaalayo Loop (EndOfStream):

EndOfStream waa property soo celiya true marka la gaaro dhammaadka faylka.

StreamReader reader;
try
{
    reader = File.OpenText("courses.txt");
    while (!reader.EndOfStream) // ama while (reader.EndOfStream == false)
    {
        string line = reader.ReadLine();
        listBox1.Items.Add(line);
    }
    reader.Close();
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}


5.6 The OpenFileDialog and SaveFileDialog Controls

Controls-kan waxay soo bandhigaan daaqadaha caadiga ah ee Windows ee lagu furo (Open) ama lagu kaydiyo (Save As) faylasha. Waxay ka soo muuqdaan qaybta hoose ee Designer-ka ee loo yaqaan Component Tray.

1. OpenFileDialog:

StreamReader reader;
DialogResult result = openFileDialog1.ShowDialog();

if (result == DialogResult.OK)
{
    // Fur faylka uu isticmaaluhu doortay adigoo isticmaalaya FileName
    reader = File.OpenText(openFileDialog1.FileName);
    while (!reader.EndOfStream)
    {
        listBox1.Items.Add(reader.ReadLine());
    }
    reader.Close();
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Waa la joojiyay (Cancelled)");
}


(Waxaad kaloo dejin kartaa galka ugu horreeya ee furmaya adigoo isticmaalaya: openFileDialog1.InitialDirectory = @"C:\Data";).

2. SaveFileDialog:

StreamWriter write;
DialogResult result = saveFileDialog1.ShowDialog();

if (result == DialogResult.OK)
{
    // Abuur faylka goobta uu isticmaaluhu doortay
    write = File.CreateText(saveFileDialog1.FileName);
    write.WriteLine("Mohamed");
    write.Close();
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Waa la joojiyay (Cancelled)");
}


5.7 Random Numbers

.NET wuxuu leeyahay class-ka Random si loo soo saaro tirooyin bakhtiyaa-nasiib ah:

Next(): Wuxuu soo saaraa tiro buuxda (int) oo random ah (0 ilaa 2,147,483,647).

Next(max): Wuxuu soo saaraa tiro u dhaxaysa 0 ilaa max - 1.

NextDouble(): Wuxuu soo saaraa tiro jajab ah (double) oo u dhaxaysa 0.0 ilaa 1.0.

Random rand = new Random();

int number1 = rand.Next();       // Tiro kasta oo int ah
int number2 = rand.Next(100);    // Tiro u dhaxaysa 0 ilaa 99
double number3 = rand.NextDouble(); // Tiro u dhaxaysa 0.0 ilaa 1.0


5.8 The Load Event

Marka barnaamijku bilowdo ee Form-ka lagu shubo xusuusta (memory), waxaa dhaca event loo yaqaan Load. Si aad u abuurto, laba jeer guji (double-click) meel bannaan oo Form-ka ka mid ah.

private void Form1_Load(object sender, EventArgs e)
{
    // Koodh kasta oo halkan lagu qoro wuxuu shaqaynayaa isla marka barnaamijku furmo
    MessageBox.Show("Prepare to see the form!");
}
