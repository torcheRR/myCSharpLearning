    // Mantıksal operatörler
    
    var a = true;
    var b = true;
    var c = false;
    var d = false;
    
    // 1- ve - &&
    var sonuc = (a &&b);
    sonuc = (a&&c);
    sonuc = (c&&d);
    
    //2- veya - ||
    sonuc = (a||b);
    sonuc=(c||b);
    sonuc = (c||d);
    
    //3- değil - !
    sonuc = !c;
    

    Console.WriteLine(sonuc);