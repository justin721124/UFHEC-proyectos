BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Consultas" (
	"Id"	INTEGER,
	"MascotaId"	INTEGER NOT NULL,
	"VeterinarioId"	INTEGER NOT NULL,
	"Fecha"	date,
	"Diagnostico"	TEXT,
	"Tratamiento"	TEXT,
	"Precio"	REAL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("MascotaId") REFERENCES "Mascotas"("Id"),
	FOREIGN KEY("VeterinarioId") REFERENCES "Veterinarios"("Id")
);
CREATE TABLE IF NOT EXISTS "Dueños" (
	"Id"	INTEGER,
	"Nombre"	TEXT NOT NULL,
	"Apellido"	TEXT NOT NULL,
	"Telefono"	TEXT,
	"Direccion"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Especies" (
	"Id"	INTEGER NOT NULL,
	"Nombre"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Mascotas" (
	"Id"	INTEGER,
	"Nombre"	TEXT NOT NULL,
	"Edad"	INTEGER,
	"Color"	TEXT,
	"Sexo"	TEXT,
	"EstadoSalud"	TEXT,
	"FechaNacimiento"	date,
	"DueñoId"	INTEGER NOT NULL,
	"EspecieId"	INTEGER NOT NULL,
	"RazaId"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("DueñoId") REFERENCES "Dueños"("Id"),
	FOREIGN KEY("EspecieId") REFERENCES "Especies"("Id"),
	FOREIGN KEY("RazaId") REFERENCES "Razas"("Id")
);
CREATE TABLE IF NOT EXISTS "Razas" (
	"Id"	INTEGER,
	"Nombre"	TEXT NOT NULL,
	"EspecieId"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("EspecieId") REFERENCES "Especies"("Id")
);
CREATE TABLE IF NOT EXISTS "Veterinarios" (
	"Id"	INTEGER,
	"Nombre"	TEXT NOT NULL,
	"Apellido"	TEXT NOT NULL,
	"Telefono"	TEXT,
	"Especialidad"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
INSERT INTO "Consultas" VALUES (1,1,1,'2026-07-10','Chequeo General','Vitaminas',500.0);
INSERT INTO "Consultas" VALUES (2,2,2,'2026-07-10','Otitis','Gotas óticas',850.0);
INSERT INTO "Consultas" VALUES (3,3,1,'2026-07-10','Vacunación','Aplicación de vacuna',700.0);
INSERT INTO "Dueños" VALUES (1,'María','Gómez','809-555-1234','La Romana');
INSERT INTO "Dueños" VALUES (2,'Juan','Pérez','829-555-5678','Santo Domingo');
INSERT INTO "Dueños" VALUES (3,'Ana','Rodríguez','849-555-9876','Higüey');
INSERT INTO "Especies" VALUES (1,'Perro');
INSERT INTO "Especies" VALUES (2,'Gato');
INSERT INTO "Especies" VALUES (3,'Ave');
INSERT INTO "Especies" VALUES (4,'Conejo');
INSERT INTO "Mascotas" VALUES (1,'Rocky',5,'Marrón','Macho','Saludable','2020-03-15',1,1,1);
INSERT INTO "Mascotas" VALUES (2,'Luna',3,'Blanco','Hembra','Saludable','2022-01-20',1,2,3);
INSERT INTO "Mascotas" VALUES (3,'Max',2,'Negro','Macho','En tratamiento','2023-06-10',2,1,2);
INSERT INTO "Razas" VALUES (1,'Pastor Alemán',1);
INSERT INTO "Razas" VALUES (2,'Chihuahua',1);
INSERT INTO "Razas" VALUES (3,'Persa',2);
INSERT INTO "Razas" VALUES (4,'Siamés',2);
INSERT INTO "Razas" VALUES (5,'Canario',3);
INSERT INTO "Razas" VALUES (6,'Lop',4);
INSERT INTO "Veterinarios" VALUES (1,'Carlos','Martínez','809-111-1111','Medicina General');
INSERT INTO "Veterinarios" VALUES (2,'Laura','Fernández','809-222-2222','Cirugía');
COMMIT;
