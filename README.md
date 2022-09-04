# Kodlama.io.Devs

**Req 1 :**

* Programlama dillerini(C#,Java,Python) ekleyebilecek, silebilecek, güncelleyebilecek, listeleyebilecek, id ile getirebilecek kodları yazınız.
* İsimler tekrar edemez.
* Programlama dili boş geçilemez.

## Add Migrations

'dotnet ef migrations add "InitialCreate" --context MsSqlQueryDbContext --project src/Kodlama.io.Devs.Persistence/ --startup-project src/Kodlama.io.Devs.WebAPI/'

'dotnet ef migrations add "InitialCreate" --context MsSqlCommandDbContext --project src/Kodlama.io.Devs.Persistence/ --startup-project src/Kodlama.io.Devs.WebAPI/
'

## Update Database

'dotnet ef database update --context MsSqlQueryDbContext --project src/Kodlama.io.Devs.Persistence/ --startup-project src/Kodlama.io.Devs.WebAPI/'

'dotnet ef database update --context MsSqlCommandDbContext --project src/Kodlama.io.Devs.Persistence/ --startup-project src/Kodlama.io.Devs.WebAPI/
'
