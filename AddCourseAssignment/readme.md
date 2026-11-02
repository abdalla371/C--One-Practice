# Course Registration System (Windows Forms - C#)

Nidaamkan waa barnaamij ku shaqeeya **C# Windows Forms**, kaas oo loogu talagalay in lagu maamulo diiwaangelinta koorsooyinka ardayda, xisaabinta lacagaha, qiimo-dhimisyada (discounts), iyo hubinta xogta ardayda (input validation).

---

## 🚀 Concepts-ka Ugu Muhiimsan ee Laga Isticmaalay Koodka

Mashruucan wuxuu isugu jiraa mabaadii' aad muhiim ugu ah barashada barnaamij-sameynta (Programming Concepts). Hoos waxaa ku qoran sharaxaadda fikradahaas:

### 1. Exception Handling (`try-catch`)
* **Waa maxay?** Waa hab lagu xakameeyo khaladaadka lama-filaanka ah ee dhaca inta barnaamijku shaqeynayo (Runtime Errors).
* **Sidee loo isticmaalay?** Badhamada oo dhan (Add, Remove, Calculate, Clear) waxaa lagu dhex duuduubay block-ka `try-catch`. Haddii cilad dhacdo, barnaamijku ma xirmayo ee wuxuu soo saarayaa fariin macquul ah oo isticmaaluhu fahmi karo iyadoo la adeegsanayo `ex.Message`.

### 2. Input Validation & Type Parsing (`TryParse`)
* **Waa maxay?** Waa hubinta in xogta uu isticmaaluhu soo geliyey ay sax tahay ka hor intaan la baaraandigin.
* **Sidee loo isticmaalay?** 
  * Waxaa la isticmaalay `double.TryParse` iyo `int.TryParse` si loo hubiyo in qiimaha (price) iyo da'da (age) ay yihiin tirooyin sax ah oo aanay ahayn qoraal caadi ah.
  * Sidoo kale, waxaa la hubiyey in sanduuqyada qoraalka aysan madhnayn (`textBoxId.Text == ""`) iyo in da'du ay ku jirto xadka loo baahan yahay (16 ilaa 60 sano).

### 3. Loops (`while` Loop & ListBox Iteration)
* **Waa maxay?** Waa hab lagu celceliyo fulinta qayb ka mid ah koodka ilaa shuruud gaar ah laga gaarayo.
* **Sidee loo isticmaalay?** Badhanka Xisaabinta (`Calculate`) wuxuu adeegsanayaa `while` loop si uu dhex maro dhammaan koorsooyinka ku jira `listBox1` hal mid, si uu wadarta guud ee lacagta (`basicFee`) uga soo saaro iyada oo aan gacanta lagu qorin tirada koorsooyinka.

### 4. String Manipulation (`IndexOf` & `Substring`)
* **Waa maxay?** Waa farsamooyin lagu baaro, lagu raadiyo, ama looga soo gooyo qaybo ka mid ah xarfo ama qoraallo (strings).
* **Sidee loo isticmaalay?** Markii la xisaabinayey qiimaha koorsooyinka liiska ku jira:
  * `itemText.IndexOf('$')` waxaa loo isticmaalay in lagu raadiyo halka ay ku taallo calaamada dollar-ka (`$`).
  * `itemText.Substring(...)` waxaa loo isticmaalay in laga soo gooyo qiimaha saafi ah ee ka dambeeya calaamada `$` si loogu daro xisaabta.

### 5. Conditional Statements (`if-else-if`)
* **Waa maxay?** Waa kala-doorashada barnaamijka ku salaysan shuruudo kala duwan.
* **Sidee loo isticmaalay?** 
  * **Xadka Koorsooyinka:** In aan la ogolayn in ka badan 5 koorso, ama in la xaqiijiyo in ugu yaraan hal koorso la diiwaangeliyey.
  * **Tirada Qiimo-dhimista (Course Discount):** Boqolleyda qiimo-dhimista waxay ku xiran tahay tirada koorsooyinka (1 koorso = 0%, 2 koorso = 5%, 3-4 koorso = 10%, 5 koorso = 15%).
  * **Deeqda Waxbarasho (Scholarship):** Waxaa la hubiyaa haddii `checkboxScholarship` uu yahay mid la doortay (`Checked`), taas oo ardayga siinaysa 20% oo dheeraad ah oo laga dhimayo lacagta asaasiga ah.

### 6. Formatting (`ToString("0.00")`)
* **Waa maxay?** Waa habka loo qurxiyo laguna soo bandhigo nambarada ama lacagaha si ay u yeeshaan laba tiro oo desimal ah (`.00`).
* **Sidee loo isticmaalay?** Dhammaan qiimayaasha lacagaha (Basic Fee, Discounts, Final Fee) waxaa lagu muujiyey iyadoo la isticmaalayo `ToString("0.00")` si ay ugu ekaadaan lacag rasmi ah (tusaale: `$150.00`).

---

## 🛠 Qalabka la Adeegsaday (Tools & Technologies)
* **Luqadda:** C# (.NET Framework)
* **Nooca App-ka:** Windows Forms Application
* **Kontoroolada la isticmaalay:** `Form`, `TextBox`, `ListBox`, `Button`, `CheckBox`, `Label`, `MessageBox`.
