# Bank Automation and OOP

This project is a simple bank automation written in c# language. Oracle is preferred as database. The database file is not available in the project.

If you want to create a database, you can create a file named BANKADB.sql and enter the codes below to create a database and associate it with the project.

```
CREATE TABLE "SYSTEM"."HESAP" (	"NO" NUMBER, "EKBAKİYE" NUMBER, "MUSTERİNO" NUMBER, CONSTRAINT "HESAP_pk" PRIMARY KEY (NO))
CREATE TABLE "SYSTEM"."MUSTERI" (	"ID" VARCHAR2(20 BYTE), "AD" VARCHAR2(20 BYTE), "SOYAD" VARCHAR2(20 BYTE), "SIFRE" VARCHAR2(20 BYTE), "TARIH" DATE, "MUSTERITIPI" VARCHAR2(20 BYTE),CONSTRAINT "MUSTERI_PK" PRIMARY KEY (ID) )
CREATE TABLE "SYSTEM"."PARARAPOR" (	"RAPOR" VARCHAR2(250 BYTE), "TARIH" DATE, "MUSTERİNO" NUMBER, "NO" NUMBER,CONSTRAINT "PARARAPOR_PK" PRIMARY KEY (NO))
CREATE TABLE "SYSTEM"."PERSONEL" (	"ID" VARCHAR2(20 BYTE), "AD" VARCHAR2(20 BYTE), "SOYAD" VARCHAR2(20 BYTE), "SIFRE" VARCHAR2(20 BYTE), )
CREATE TABLE "SYSTEM"."RAPOR" (	"RAPOR" VARCHAR2(500 BYTE), "TARIH" DATE)
```
I made this project to learn object oriented programming and oracle database.

In order to use automation, must login without a password with "yönetici girişi" and must add personnel, add customers with personnel login.
