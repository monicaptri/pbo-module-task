using System;
using System.Collections.Generic;

// Kelas dasar Hewan (Soal 2a)
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    // Soal 3a
    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    // Soal 3b
    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

// Kelas Mamalia (Soal 2b)
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

// Kelas Reptil (Soal 2c)
public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

// Kelas Singa (Soal 2d)
public class Singa : Mamalia
{
    // Soal 4: Override method Suara()
    public override string Suara()
    {
        return "Groarrr!";
    }

    // Soal 5a: Tambahkan method khusus Mengaum()
    public string Mengaum()
    {
        return "Singa mengaum dengan keras!";
    }
}

// Kelas Gajah (Soal 2d)
public class Gajah : Mamalia
{
    // Soal 4: Override method Suara()
    public override string Suara()
    {
        return "Trrruuuut!";
    }
}

// Kelas Ular (Soal 2e)
public class Ular : Reptil
{
    // Soal 4: Override method Suara()
    public override string Suara()
    {
        return "Ssssss!";
    }

    // Soal 5b: Tambahkan method khusus Merayap()
    public string Merayap()
    {
        return "Ular merayap dengan lincah!";
    }
}

// Kelas Buaya (Soal 2e)
public class Buaya : Reptil
{
    // Soal 4: Override method Suara()
    public override string Suara()
    {
        return "Grrrr!";
    }
}

// Kelas KebunBinatang (Soal 2f)
public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    // Soal 6a: Method TambahHewan()
    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    // Soal 6b: Method DaftarHewan()
    public void DaftarHewan()
    {
        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Soal 7a: Buat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Soal 7b: Buat beberapa objek dari berbagai jenis hewan
        Singa singa = new Singa { Nama = "Simba", Umur = 5, JumlahKaki = 4 };
        Gajah gajah = new Gajah { Nama = "Trunk", Umur = 10, JumlahKaki = 4 };
        Ular ular = new Ular { Nama = "Cobra", Umur = 3, PanjangTubuh = 2.5 };
        Buaya buaya = new Buaya { Nama = "E yu", Umur = 7, PanjangTubuh = 3.0 };

        // Soal 7c: Tambahkan hewan-hewan tersebut ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Soal 7d: Panggil method DaftarHewan()
        kebunBinatang.DaftarHewan();

        // Soal 7e: Demonstrasikan penggunaan polymorphism
        Console.WriteLine("\nDemonstrasi Polymorphism:");
        Console.WriteLine($"Suara Singa: {singa.Suara()}");
        Console.WriteLine($"Suara Gajah: {gajah.Suara()}");
        Console.WriteLine($"Suara Ular: {ular.Suara()}");
        Console.WriteLine($"Suara Buaya: {buaya.Suara()}");

        // Soal 7f: Panggil method khusus
        Console.WriteLine("\nMethod Khusus:");
        Console.WriteLine(singa.Mengaum());
        Console.WriteLine(ular.Merayap());

        // Jawaban pertanyaan analisis
        Console.WriteLine("\nJawaban Pertanyaan Analisis:");

        // Soal 1
        Console.WriteLine("1. Suara Gajah dan Ular:");
        Console.WriteLine($"Gajah: {gajah.Suara()}");
        Console.WriteLine($"Ular: {ular.Suara()}");

        // Soal 2
        Console.WriteLine("\n2. Mengaum Singa:");
        Console.WriteLine(singa.Mengaum());

        // Soal 3
        Console.WriteLine("\n3. Informasi lengkap Singa:");
        Console.WriteLine(singa.InfoHewan());

        // Soal 4
        Console.WriteLine("\n4. Merayap Ular:");
        Console.WriteLine(ular.Merayap());

        // Soal 5
        Console.WriteLine("\n5. Reptil sebagai Buaya:");
        Reptil reptil = new Buaya { Nama = "Croc", Umur = 6, PanjangTubuh = 2.8 };
        Console.WriteLine($"Suara: {reptil.Suara()}");
    }
}