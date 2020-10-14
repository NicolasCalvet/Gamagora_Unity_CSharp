## Exercice 1 :

Plusieurs erreurs :

- La variable ***age*** doit avoir une portée plus globale, au moins au niveau de la fonction Main.
- La variable ***age*** doit donc être initialisé (à 0 par exemple ou avec une entrée utilisateur).
- La première condition est fausse. Il s'agit d'une affectation à la variable prénom plutôt que d'un teste d'égalité. Il faut remplacer ''='' par '=='.
- Il manque une accolade après la seconde condition.
- Bonus : par sécurité il est préférable de toujours écrire les accolades. Donc dans la dernière condition, il est préférable d'ajouter les accolades. Cela peut éviter certains bugs si le code est modifié.



## Exercice 2 :

```csharp
static void Main(string[] args) {

    string prenom;
    string civilite;
    int age;

    // Reading first name
    do {
        Console.WriteLine("Veuillez entrer votre prénom : ");
        prenom = Console.ReadLine();
    } while (prenom == "");

    // Reading civility
    do {
        Console.WriteLine("Veuillez entrer votre civilité (M. / Mme.) : ");
        civilite = Console.ReadLine();
    } while (!civilite.Equals("M.") && !civilite.Equals("Mme.") );

    // Reading age
    do {
        Console.WriteLine("Veuillez entrer votre age : ");
        age = int.Parse(Console.ReadLine());
    } while (age < 0);

    if (civilite == "M.") {
        Console.WriteLine(prenom + ", vous êtes un homme de " + age + " ans");
    }
    else if(civilite == "Mme.") {
        Console.WriteLine(prenom + ", vous êtes une femme de " + age + " ans");
    }

    if (age >= 18) {
        Console.WriteLine(prenom + ", vous êtes majeur");
    }

}
```



## Exercice 3 :

```csharp
static void Exo3() {

    Pizza reine = new Pizza(5.0f, 10.5f);
    Pizza royale = new Pizza(10.0f, 20f);

    ComparePizza(reine, royale);

}

static void ComparePizza(Pizza reine, Pizza royale) {
    float reineEffciency = reine.Efficiency();
    float royaleEfficiency = royale.Efficiency();

    if (reineEffciency > royaleEfficiency) {

        Console.WriteLine("La reine est moins chère !");

    } else if (royaleEfficiency > reineEffciency) {

        Console.WriteLine("La royale est moins chère !");

    } else {
        Console.WriteLine("Elles sont équivalentes !");
    }
}
```

Classe Pizza :

```csharp
class Pizza {

    public float rayon;
    public float prix;

    public Pizza(float rayon, float prix) {
        this.rayon = rayon;
        this.prix = prix;
    }

    public float Efficiency() {
        return MathF.Pow(rayon, 2.0f) * MathF.PI / prix;
    }
}
```



## Exercice 4 :

```csharp
static void Exo4() {

    int maxValue;

    // Reading value
    do {
        Console.WriteLine("Veuillez entrer un nombre > 0 : ");
        maxValue = int.Parse(Console.ReadLine());
    } while (maxValue <= 0);

    for (int i = 0; i < maxValue; i++) {
        Console.WriteLine("Factorielle de " + i + "! = " + Factorielle(i));
    }

}

static int Factorielle(int nombre) {
    if (nombre > 1) {
        return nombre * Factorielle(nombre - 1);
    } else {
        return 1;
    }
}
```



## Exercice 5 :

```csharp
static void Exo5() {
    int maxValue;
    // Reading value
    do {
        Console.WriteLine("Veuillez entrer un nombre > 0 : ");
        maxValue = int.Parse(Console.ReadLine());
    } while (maxValue <= 0);

    for (int i = 0; i < maxValue; i++) {
        for (int j = 0; j < maxValue; j++) {

            if ( ((i + j) % 2) == 1) {
                Console.WriteLine("( " + i + ", " + j + " )");
            }

        }
    }
}
```



## Exercice 6 :

```csharp
static void Exo6() {

    string str;

    // Reading string
    do {
        Console.WriteLine("Veuillez entrer un mot / une phrase : ");
        str = Console.ReadLine();
    } while (str == "");

    foreach (char c in str) {
        Console.WriteLine(c);
    }

}
```



## Exercice 7 :

```csharp
static void Exo7() {

    Debug.Assert(removeConsonants("Il fait toujours beau !").Equals("I ai ouou eau !"));
    Debug.Assert(removeConsonants("Aled").Equals("Ae"));

    string str;

    // Reading string
    do {
        Console.WriteLine("Veuillez entrer un mot / une phrase : ");
        str = Console.ReadLine();
    } while (str == "");

    Console.WriteLine("Sans consonnes :");
    Console.WriteLine(removeConsonants(str));

}


static string removeConsonants(string baseStr) {

    string result = "";

    foreach (char c in baseStr) {
        char tempC = char.ToUpper(c);
        if (!IsConsonant(tempC)) {
            result += c;
        }
    }

    return result;
}

//Based on upper format
static bool IsConsonant(char c) {

    // Checking if in alphabet range
    if (c < 65 || c > 90) {
        return false;
    }

    if (c == 65 || c == 69 || c == 73 || c == 79 || c == 85) {
        return false;
    }

    return true;
}
```

