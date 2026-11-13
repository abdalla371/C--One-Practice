📘 Chapter 3: Making Decisions (Go'aan Qaadashada ee Visual C#)

Kani waa sharraxaad dhammaystiran oo ku saabsan cutubka Making Decisions (Go'aan Qaadashada) ee luqadda Visual C# (buugga Starting Out with Visual C# ee Tony Gaddis). Cutubkan waxaan ku baranaynaa sida barnaamijku u qaato go'aanno ku salaysan shuruudo (conditions) kala duwan.

📋 Mowduucyada Cutubka (Topics)

4.1 Decision Structures & the if Statement

4.2 The if-else Statement

4.3 Nested Decision Structures & if-else-if

4.4 Logical Operators (Hawl-wadeennada Macquulka ah)

4.5 bool Variables and Flags

4.6 Comparing Strings (Isbarbardhigga Qoraallada)

4.7 Preventing Data Conversion Exceptions (TryParse)

4.8 Input Validation (Hubinta Xogta la Geliyo)

4.9 Radio Buttons and Check Boxes

4.10 The switch Statement

4.11 Introduction to List Boxes (ListBox)

4.1 Decision Structures & the if Statement

Control Structure: Waa qaab-dhismeed maamula sida iyo sida ay u kala horreeyaan fulinta koodhka (statements).

Sequence Structure: Waa koodh u shaqeeya si toos ah (sida ay u kala sarreeyaan).

Decision Structure: Waa qaab-dhismeed fuliya koodh gaar ah kaliya marka ay jirto shuruud gaar ah oo run (true) noqota.

Qaabka Guud ee if Statement:

if (expression)
{
    // Koodhkan wuxuu shaqaynayaa haddii expression-ku noqdo true
}


Relational Operators (Hawl-wadeennada Isbarbardhigga)

Waxaa loo isticmaalaa in lagu hubiyo xiriirka ka dhexeeya laba qiime:

Operator

Macnaha

Tusaale

>

Ka weyn (Greater than)

x > y

<

Ka yar (Less than)

x < y

>=

Ka weyn ama la mid ah

x >= y

<=

Ka yar ama la mid ah

x <= y

==

La mid ah (Equal to)

x == y

!=

Aan la mid ahayn (Not equal to)

x != y

4.2 The if-else Statement

if-else wuxuu fuliyaa hal qayb oo koodh ah haddii shuruuddu run (true) noqoto, qaybta kalena (else) wuxuu fuliyaa haddii shuruuddu been (false) noqoto.

Tusaale Koodh ah (if-else):

🧪 Practice Lab: Test Score Average (try-catch & if)

Tusaalahan wuxuu xisaabinayaa celceliska (average) saddex imtixaan, wuxuuna isticmaalayaa try-catch si looga hortago qaladaadka, iyo if si loogu hambalyeeyo ardayga keena dhibco ka sarreeya 95.0.

4.3 Nested Decision Structures & if-else-if

Nested Decision Structures (Go'aanno Is-dhex-jira)

Waa marka hal if statement lagu dhex qoro if kale gudihiisa si loo tijaabiyo in ka badan hal shuruud (tusaale: hubinta mushaharka iyo sannadaha shaqada si qofka loogu oggolaado deyn/loan).

The if-else-if Statement

Waxaa la isticmaalaa marka la rabo in la qiimeeyo shuruudo badan oo isku xiga si loo gaaro go'aanka ugu dambeeya (sida soo saarista darajada imtixaanka: A, B, C, D, F).

4.4 Logical Operators

Waxay isku xiraan laba shuruudood (Boolean expressions) ama ka badan si ay u sameeyaan hal shuruud oo weyn:

Operator

Magaca

Sharraxaad

&&

AND

Labada shuruudoodba waa inay true noqdaan si natiijadu true u noqoto.

||

OR

Ugu yaraan hal shuruud ayaa true noqonaysa si natiijadu true u noqoto.

!

NOT

Wuxuu rogaa qiimaha (true wuxuu ka dhigaa false, false-na true).

// Tusaale AND (&&)
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// Tusaale OR (||)
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}


4.5 bool Variables and Flags

Doorsoomaha noociisu yahay bool wuxuu kaydiyaa kaliya true ama false.

Flag: Waa doorsoome bool ah oo calaamad u ah in xaalad gaar ah ay ka jirto barnaamijka dhexdiisa.

4.6 Comparing Strings

Qoraallada (string) waxaa lagu isbarbardhigi karaa ==, !=, ama hababka (methods) sida String.Compare iyo .CompareTo(). Haddii natiijada CompareTo ay la mid tahay 0, labada qoraal way isku mid yihiin.

4.7 Preventing Data Conversion Exceptions (TryParse)

Si looga hortago in barnaamijku istaago (crash/exception) haddii isticmaaluhu geliyo xog khaldan (sida xarfo meel tiro laga rabay), waxaa la isticmaalaa hababka TryParse:

int.TryParse(input, out targetVariable)

double.TryParse(input, out targetVariable)

decimal.TryParse(input, out targetVariable)

int hours;
if (int.TryParse(textBox1.Text, out hours))
{
    // Xogtu waa sax waana la beddelay!
}


4.8 Input Validation

Input Validation waa hubinta in xogta la geliyay ay tahay mid macquul ah oo u dhaxaysa xadka la oggol yahay ka hor intaan la isticmaalin.

// Hubinta in dhibcaha imtixaanku u dhexeeyaan 0 ilaa 100
if (testScore >= 0 && testScore <= 100)
{
    // Waa xog sax ah
}


4.9 Radio Buttons and Check Boxes

RadioButton: Wuxuu u oggolaadaa isticmaalaha inuu doorto hal shay oo kaliya (mutually exclusive) dhowr ikhtiyaar dhexdooda.

CheckBox: Wuxuu u oggolaadaa isticmaalaha inuu doorto hal shay ama wax ka badan isku mar.

Property-ga .Checked: Wuxuu soo celiyaa true haddii la doortay, ama false haddii aan la dooran.

Event-ga CheckedChanged: Wuxuu shaqeeyaa mar kasta oo isbeddel ku yimaado doorashada RadioButton ama CheckBox.

4.10 The switch Statement

switch wuxuu qiimeeyaa qiimaha hal doorsoome (variable), wuxuuna u jiheeyaa barnaamijka qaybta (case) ku habboon qiimahaas. Wuxuu beddel u noqon karaa if-else-if dhaadheer.

switch (testExpression)
{
    case value_1:
        // statements
        break;
    case value_2:
        // statements
        break;
    default:
        // statements
        break;
}


4.11 Introduction to List Boxes

ListBox wuxuu soo bandhigaa liis walxo ah (items) oo isticmaaluhu ka dooran karo.

Properties-ka Muhiimka ah:

Text: Waxay soo celisaa qoraalka shayga markaas la doortay.

Items.Count: Waxay soo celisaa tirada guud ee walxaha ku jira ListBox-ka.

SelectedItem: Waxay haysaa shayga (object) la doortay.

SelectedIndex: Waxay haysaa lambarka booska (index-ka ka bilowda 0) ee shayga la doortay. Haddii aan waxba la dooran, qiimaheedu waa -1.

1. Soo saarista qoraalka la doortay (listBox1.Text):

2. Tirinta walxaha ku jira ListBox (listBox1.Items.Count):

Ku darista iyo Ka saarista Walxaha (Adding & Removing Items):

Ku darista (Items.Add): daysListBox.Items.Add("Monday");

Ka saarista magac ahaan (Items.Remove): daysListBox.Items.Remove("Tuesday");

Ka saarista boos ahaan (Items.RemoveAt): Waxay tirtirtaa shayga ku jira index gaar ah (iyadoo marka hore la hubinayo in SelectedIndex != -1).

Nadiifinta dhammaan (Items.Clear): daysListBox.Items.Clear();
