
# Sharraxaadda Koodhka Assignment 8 (Windows Forms App)

Mashaariicdan waxaa loogu talagalay in lagu barto sida faylasha loo abuuro, loo akhriyo, loo tirtiro, iyo sida koodhka C# uu ula shaqeeyo kontoroolka `ListBox`. Hoos waxaa ku qoran sharraxaad faahfaahsan oo mid mid ah button-kasta iyo shaqada uu qabanayo.

---

## 1. Abuurista Faylka iyo Wax ka Qoortiisa (`button1_Click`)

Ujeeddada button-kan waa in uu abuurom fayl cusub oo loo bixiyay `output.txt` isla markaana uu qoraal gaar ah gudaha u galiyo.

```csharp
private void button1_Click(object sender, EventArgs e)
{
    // B. Bayaaminta variable loo isticmaalayo qoraalka faylka
    StreamWriter outputFile;

    // T. Abuurista ama furista faylka "output.txt"
    outputFile = File.CreateText("output.txt");

    // J. Ku qorista safaf qoraal ah faylka
    outputFile.WriteLine("Hello Ustad");
    outputFile.WriteLine("my name is Muhammad Ali");
    outputFile.WriteLine("I am a student");
    outputFile.WriteLine("At University of Jamhuriya");

    // X. Xidhista faylka si xogtu u kaydsanto oo loo xoreeyo meemorida
    outputFile.Close();
}

 * StreamWriter outputFile;: Waxay caddaynaysaa variable-ka outputFile oo ka tirsan fasalka StreamWriter.
 * File.CreateText("output.txt");: Waxay abuuraysaa fayl cusub oo la yidhaahdo output.txt (haddii uu horay u jireayna waa uu tirtirayaa oo cusub ka dhigayaa).
 * outputFile.WriteLine(...): Line kasta oo qoraal ah ayay ku reebaysaa faylka gudahiisa.
 * outputFile.Close();: Faylka ayay xidhaysaa. Waxaa muhiim ah in mar walba faylka la xidho ka dib marka la qaro.
2. Ku Akhriyo Faylka Saflaynta Line-by-Line (button4_Click)
Ujeeddada button-kan waa in uu akhriyo faylka loo marayo habka saf-safka ah (ReadLine()) oo uu mid mid ugu soo daro ListBox-ka.
private void button4_Click(object sender, EventArgs e)
{
    // B. Bayaaminta variable loo isticmaalo akhrinta faylka
    StreamReader inputFile;

    // T. Furista faylka "output.txt" si loo akhriyo
    inputFile = File.OpenText("output.txt");

    string line;

    // J. Wareeg (Loop) soconaya ilaa dhammaadka faylka laga gaadho
    while (inputFile.EndOfStream == false)
    {
        // Akhri safka ugu horreeya ee aan la akhrin
        line = inputFile.ReadLine();

        // Ku dar safkaas kontoroolka ListBox-ka
        listBox1.Items.Add(line);
    }

    // X. Xidhista faylka
    inputFile.Close();
}

 * StreamReader inputFile;: Variable loo isticmaalo akhrinta faylasha text-ka ah.
 * inputFile.EndOfStream == false: Shardigan wuxuu eegayaa in faylku wali sii socdo oo aanu dhammaanin.
 * inputFile.ReadLine();: Saf kasta oo qoraal ah hal mar ayay akhrinaysaa.
 * listBox1.Items.Add(line);: Qoraalkii la akhriyay waxay si toos ah ugu soo dhiibaysaa listBox1.
3. Tirtirista Faylka (button2_Click)
Ujeeddada button-kan waa in uu tirtiro faylka output.txt kombuyuutarka ka dib marka lagu guuleysto furistiisa iyo xidhistiisa.
private void button2_Click(object sender, EventArgs e)
{
    StreamReader inputFile;

    // Furista iyo xidhista faylka
    inputFile = File.OpenText("output.txt");
    inputFile.Close();

    // Kontroolinta in faylku uu ka jiro kombuyuutarka
    if (File.Exists("output.txt"))
    {
        // Tirtirista faylka
        File.Delete("output.txt");
        MessageBox.Show("File deleted successfully.");
    }
    else
    {
        MessageBox.Show("File not found.");
    }
}

 * File.Exists("output.txt"): Waxay hubinaysaa in faylka output.txt uu ka jiro wadada (directory) mashruucu ka socdo.
 * File.Delete("output.txt");: Waxay tirtiraysaa faylkaas.
 * MessageBox.Show(...): Waxay soo bxinaysaa fariin sheegaysa in faylku ku tirtirmay iyo in kale.
4. Tirtirista Qadka La Doortay ee ListBox-ka iyo Update-ka Faylka (button3_Click)
Ujeeddada button-kan waa in uu tirtiro item-ka isticmaaluhu ka doorto listBox1, ka dibna uu faylka output.txt dib ugu qoro xogta cusub ee soo badhaadka ah.
private void button3_Click(object sender, EventArgs e)
{
    // Hubinta in qad ama item la doortay
    if (listBox1.SelectedItem != null)
    {
        // Ka tirtir item-ka la doortay ListBox-ka gudahiisa
        listBox1.Items.Remove(listBox1.SelectedItem);

        // Diyaarinta array lagu kaydiyo xogta cusub ee ListBox-ka
        string[] lines = new string[listBox1.Items.Count];
        for (int i = 0; i < listBox1.Items.Count; i++)
        {
            lines[i] = listBox1.Items[i].ToString();
        }

        // Qorista dhammaan safafkan cusub gudaha faylka "output.txt"
        File.WriteAllLines("output.txt", lines);
        MessageBox.Show("Selected item deleted successfully.");
    }
    else
    {
        MessageBox.Show("Please select an item to delete.");
    }
}

 * listBox1.SelectedItem != null: Shardi eegaya in isticmaaluhu ku dhuftay (doortay) mid ka mid ah item-ada listBox1.
 * listBox1.Items.Remove(...): Ka tirtirista item-kaas listBox1.
 * File.WriteAllLines(...): Waxay qaadanaysaa array-ga lines ee cusub oo ay mar kaliya ku qoraysaa faylka output.txt (iyadoo badalaysa wixii hore ugu jiray).
5. Ku Akhrinta Dhammaan Safaf xagga File.ReadAllLines (button5_Click)
Ujeeddada button-kan waa in la isticmaalo File.ReadAllLines si hal mar oo kaliya loogu wada akhriyo dhammaan safaf qoraalka ah array ahaan.
private void button5_Click(object sender, EventArgs e)
{
    string path = "output.txt";

    // Hubinta in faylku ka jiro wadada la tilmaamay
    if (File.Exists(path))
    {
        // Akhri dhammaan safafka oo u dhig string array ahaan
        string[] lines = File.ReadAllLines(path);

        // Ku soo bandhig saf kasta ListBox-ka
        foreach (string line in lines)
        {
            listBox1.Items.Add(line);
        }
    }
}

 * File.ReadAllLines(path): Waxay soo qaadaysaa dhammaan qoraalka faylka ee saf-safka ah iyadoo u ka bixinaysa string[] (array).
 * foreach (string line in lines): Wareeg maraya mid mid safafkii la soo akhrriyay si loogu daro listBox1.
6. Ku Akhrinta Faylka Hab Byte/Binary ah (button6_Click)
Ujeeddada button-kan waa in uu faylka u akhriyo sida xog binary ah (byte[]), taas oo ku tusaysa wadarta guud ee cabbirka faylka (Bytes).
private void button6_Click(object sender, EventArgs e)
{
    string filePath = "output.txt";

    // Akhrinta faylka oo dhan iyada oo laga dhigayo byte array
    byte[] fileBytes = File.ReadAllBytes(filePath);

    // Soo bandhigista tirada byte-yada ee faylka la soo akhriyay
    listBox1.Items.Add($"Successfully read {fileBytes.Length} bytes.");
}

 * File.ReadAllBytes(filePath): Waxay akhrinaysaa xogta faylka iyada oo u badalaysa byte[]. Waxaa badanaa loo isticmaalaa faylasha sida sawirrada ama fiidiyowyada.
 * fileBytes.Length: Waxay ka dhigan tahay wadarta guud ee xajmiga faylka ama inta byte ee uu ka kooban yahay.
7. Ku Akhrinta Xogta Xadidan Buffer ahaan (button7_Click)
Ujeeddada button-kan waa in la isticmaalo StreamReader.ReadBlock si loo akhriyo tirada xaruuf ah oo xadidan (Buffer).
private void button7_Click(object sender, EventArgs e)
{
    string filePath = "output.txt";

    // Isticmaalka 'using' si loo xaqiijiyo in StreamReader xidhmo marka shaqadu dhato
    using (StreamReader sr = new StreamReader(filePath))
    {
        // Abuurista buffer ka kooban 20 stix/xarfo
        char[] buffer = new char[20];

        // Akhri ilaa 20 xarfo oo ku shub buffer-ka
        int charsRead = sr.ReadBlock(buffer, 0, buffer.Length);

        // Ka dhig buffer-ka string oo ku soo bandhig ListBox-ka
        string result = new string(buffer, 0, charsRead);
        listBox1.Items.Add(result);
    }
}

 * using (StreamReader sr = ...): Waa hab amnigeedu sarreeyo oo faylka si otomaatig ah u xidhaya marka uu shaqada dhameysto.
 * sr.ReadBlock(buffer, 0, buffer.Length): Waxay akhrinaysaa tirada xuruufta ee ku xaddidan buffer.Length (kaas oo ah 20 xarfo) waxana ay dhiibaysaa inta xarfo ee lagu guuleystay akhrintooda.

***

Waxaad faylkan u isticmaali kartaa `README.md` ahaan gudaha mashruucaaga GitHub ama meel kasta oo aad ku xaqiijinayso sharraxaadda koodhkaaga!
