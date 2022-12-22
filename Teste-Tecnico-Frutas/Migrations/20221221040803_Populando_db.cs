using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste_Tecnico_Frutas.Migrations
{
    public partial class Populando_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Frutas(Descricao,A,B)
             VALUES ('Abacate',1,25),
                    ('Abacaxi',2,26),
                    ('Açaí',3,27),
                    ('Acerola',4,28),
                    ('Ameixa',5,29),
                    ('Amêndoa',6,30),
                    ('Amora',7,31),
                    ('Banana',8,32),
                    ('Buriti',9,33),
                    ('Cajá',10,34),
                    ('Caju',11,35),
                    ('Cereja',12,36),
                    ('Ciriguela',13,37),
                    ('Coco',14,38),
                    ('Cupuaçu',15,39),
                    ('Cacau',16,40),
                    ('Figo',17,41),
                    ('Framboesa',18,42),
                    ('Goiaba',19,43),
                    ('Graviola',20,44),
                    ('Groselha',21,45),
                    ('Guaraná',22,46),
                    ('Jabuticaba',23,47),
                    ('Jaca',24,48),
                    ('Jambo',25,49),
                    ('Jamelão',26,50),
                    ('Kiwi',27,51),
                    ('Laranja',28,52),
                    ('Limão',29,53),
                    ('Lima',30,54),
                    ('Maçã',31,55),
                    ('Macadâmia',32,56),
                    ('Mamão',33,57),
                    ('Manga',34,58),
                    ('Maracujá',35,59),
                    ('Melancia',36,60),
                    ('Melão',37,61),
                    ('Mexerica',38,62),
                    ('Morango',39,63),
                    ('Pera',40,64),
                    ('Pêssego',41,65),
                    ('Pitanga',42,66),
                    ('Pequi',43,67),
                    ('Romã',44,68),
                    ('Tangerina',45,69),
                    ('Tamarindo',46,70),
                    ('Tâmara',47,71),
                    ('Uva',48,72)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
