# AplikasiWinForm
Ini adalah sebuah aplikasi winform calculator sederhana yang dibuat menggunakan .net framework di visual studio.  
UI dari aplikasi terlihat seperti di bawah ini  
![image](https://github.com/NandaVahindra/AplikasiWinForm/assets/114988957/4b0d8632-7f74-4d7b-b4dc-05c0f1b8ceba)  
Aplikasi tersebut memiliki 4 operasi bilangan yakni tambah, kurang, kali, dan bagi.  
Aplikasi juga memiliki tombol C yang memiliki fungsi untuk clear content dari textbox dan juga sebuah tombol exit.  
Penjelasan Code :  

https://github.com/NandaVahindra/AplikasiWinForm/blob/9854d5c452e37b482a5005275200f3354623e1b4/Latihan%201%20PBKK/Form1.cs#L25-L30  
Kode untuk tombol clear. Berfungsi untuk mengosongkan isi dari semua textbox  
https://github.com/NandaVahindra/AplikasiWinForm/blob/88aa743eb422f0a593c4adaff75619e09faa9881/Latihan%201%20PBKK/Form1.cs#L32-L51
Kode untuk operasi tambah. Pada kode terdapat syarat dimana textbox nilai 1 dan nilai 2 salah satunya tidak boleh kosong. Jika kosong maka akan memunculkan error message.  
Untuk operasi, pertama konten dari textbox di parsing ke variabel double yang telah dibuat untuk masing masing nilai, kemudian ditambahkan kemudian diparsing lagi kedalam bentuk string untuk ditampilkan ke textbox hasil pada aplikasi.  
Hal yang sama juga berlaku pada operasi bilangan yang lain.  

