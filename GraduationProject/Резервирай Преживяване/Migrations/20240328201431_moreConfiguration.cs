using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Резервирай_Преживяване.Migrations
{
    public partial class moreConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "5a101cd1-775f-4302-a5e6-a704244a6a86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "99a469ff-b3aa-4ea2-a0bd-6137e9db8ed3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2322a2b2-79a0-43ec-8b09-728d8eeb3b57", "AQAAAAEAACcQAAAAEOrd/1nK2nksuuZ+GB6vozrV4QmZREuQkwgYbg3FUevOGvjQyNovrAZLHJ7E9xZiOA==", "b96b757c-4d95-41c5-b87a-2cab00f7bd33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de26bb40-e17d-45ce-abeb-9c961240b0d9", "AQAAAAEAACcQAAAAEKmr6chLgxbPniX/mVM6c5WNvhpIowHpu680XTmJj8vNa8t79+bXBytAHR67lJdT/Q==", "4d90aa21-d5de-46ec-bfdc-72496851eed2" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("32de8226-24d7-4085-9e1d-d9f5850f543c"),
                column: "Name",
                value: "Тракийската гробница");

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("4a9a7f60-babf-4582-b851-88bcba1bc831"),
                column: "CityId",
                value: new Guid("f7e3ef46-c077-48db-9655-dfbb6849b39f"));

            migrationBuilder.InsertData(
                table: "Landmarks",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name" },
                values: new object[] { new Guid("ad16eaf3-5686-4367-90d0-ab3a50146cc9"), new Guid("f7e3ef46-c077-48db-9655-dfbb6849b39f"), "Храм-паметникът „Александър Невски“ е своеобразна емблема на столицата. Той е разположен в центъра на София, а площадът, на който се намира, носи неговото име. Катедрален храм е изграден в чест на император Александър II, армията на която освобождава България през 1878 година. Храмът за името Св. Александър Невски, който е светец, покровителства Александър II и символизира руската бойна слава. Петко Каравелов предлага да се изгради такъв храм в Търново, но княз Батенберг настоява това да се случи в София. Храмът е изграден от дарения от народа. Строежът започва през 1904 г., въпреки че основният камък е през 1882 г. Храмът е завършен през 1912 г. осветен през 1924 г. Проектът е изработен от Александър Померанцев, професор от Художествената академия в Санкт Петербург. За патриаршеска катедрала храмът бива обявен на 1 януари 1951 г. Катедрален храм е с площ от 3170 кв. м и може да събере 5000 души. За облицовката е използван бял врачански камък. Вратите са от славонски дъб, а куполите са с позлата. Камбанарията, която е на 53 метра от земята, има 12 камбани, чийто звън се чува на 1 км. в радиус. Всички те са изливани и докарани от Москва през 1911 г. Върху стенописите на храма са работили български, чешки и руски художници. Уникални са двата трона - царският и патриарше. Храмът разполага с три олтара, всеки със своето име: Централен - “Св. Ал. Невски \" Северен - „Св.св. Кирил и Методий “ Южен - „Св. цар Борис “ Мистични с прозорците на храма. През тях не може да се гледа. Тяхната роля е да пропуснат дневната светлина, но в такава степен, че тя е такава, каквато е хармонизиран мрак и светлината и взаимно тържествуват. В криптата на храма, която през 1965 г. става филиал на Националната Художествена Академия, се съхранява ценни икони от български майстори. Сега тя е включена във всички туристически пътеводители за България.", "https://cathedral.bg/pic/pages/2019-07/80/gals/nevski.jpg", "Свети Александър Невски" });

            migrationBuilder.InsertData(
                table: "Resorts",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name", "Stars", "Type" },
                values: new object[] { new Guid("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"), new Guid("f7e3ef46-c077-48db-9655-dfbb6849b39f"), "Хотел Арт Магус се намира в София, на 3,1 км от Боянската църква. Предлага помещения за настаняване с ресторант, частен паркинг и казино. Този 4-звезден хотел разполага с фитнес център и климатизирани стаи с безплатен WiFi, всяка със самостоятелна баня. На разположение на гостите има детски клуб, банкомат и помещение за съхранение на багаж. Стаите за гости в хотела са оборудвани с телевизор с плосък екран. Стаите са оборудвани с минибар. На място се сервира а-ла-карт, континентална или вегетарианска закуска. Персоналът на рецепцията говори български и английски език и е готов да съдейства на гостите по всяко време на деня. Западният парк е на 6,8 километра от Art Magus Hotel, а джамията Баня Баши е на 7 километра. Летище София е най-близкото летище и е разположено на 13 километра.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/408387413.jpg?k=109ec34840ad29eefddc2ce60d331cdce2b9f00a73405bf4d0415155857b611c&o=&hp=1", "Art Magus Hotel", "4", "Хотел" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Gym", "Parking", "Pool", "ResortId", "Restaurant", "RoomService", "SpaCenter", "Wifi" },
                values: new object[] { new Guid("bcbf6201-48fc-4ea2-a167-793ac221b5a3"), true, true, false, new Guid("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"), true, true, false, true });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Description", "IsTaken", "PricePerNight", "ResortId", "Type" },
                values: new object[,]
                {
                    { new Guid("2c21f5d9-dc4e-4e2c-b4b7-f0a719e96650"), "4", "Арт Джуниор суит се състои от две преходни стаи, луксозна баня и кът за отдих. Тук ще намерите и кухненски бокс, за да се чувствате наистина като у дома си! Веднъж когато видите вратата на стаята си, няма да я забравите, защото е с уникална неповторима картина.", null, 250m, new Guid("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"), "Апартамент" },
                    { new Guid("3dc4f47b-086a-417b-a056-43fc084cd25d"), "2", "Двойните стаи са обзаведени в елегантен артстил, ергономични и хипоалергенни матраци, с богато зареден минибар и телевизор с плосък екран. Освен това можем да поставим допълнително легло по Ваше желание. Веднъж когато видите вратата на стаята си, няма да я забравите, защото е с уникална неповторима картина.", null, 80m, new Guid("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"), "Двойна стая" },
                    { new Guid("3fd28cb9-1944-4786-8cb3-1bd04a4b4d6c"), "2", "Art Делукс стаите са обзаведени в елегантен артстил, ергономични и хипоалергенни матраци, с богато зареден минибар и телевизор с плосък екран. Освен това можем да поставим допълнително легло по Ваше желание. Веднъж когато видите вратата на стаята си, няма да я забравите, защото е с уникална неповторима картина.", null, 100m, new Guid("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"), "Двойна делукс стая" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "RoomId", "Url" },
                values: new object[,]
                {
                    { new Guid("32688fbb-ba73-495a-9acd-81a2848fe603"), new Guid("3dc4f47b-086a-417b-a056-43fc084cd25d"), "https://art.magusexperience.com/wp-content/uploads/2020/03/23.jpg" },
                    { new Guid("46f00b54-6702-46d9-b847-b07e4c330fcf"), new Guid("3dc4f47b-086a-417b-a056-43fc084cd25d"), "https://art.magusexperience.com/wp-content/uploads/2020/03/21.jpg" },
                    { new Guid("593703e4-7390-4ac5-bf7c-403b57ee9ff3"), new Guid("3dc4f47b-086a-417b-a056-43fc084cd25d"), "https://art.magusexperience.com/wp-content/uploads/2020/03/plabo.net-0395.jpg" },
                    { new Guid("80653e22-de9c-4484-8063-8cb8939a35ba"), new Guid("3fd28cb9-1944-4786-8cb3-1bd04a4b4d6c"), "https://art.magusexperience.com/wp-content/uploads/2020/03/17.jpg" },
                    { new Guid("b1ac92c9-210a-4918-b1b7-24ec84ac6f04"), new Guid("3fd28cb9-1944-4786-8cb3-1bd04a4b4d6c"), "https://art.magusexperience.com/wp-content/uploads/2020/03/19.jpg" },
                    { new Guid("b5e5fcdd-0436-4b6e-9886-dc05766892d7"), new Guid("2c21f5d9-dc4e-4e2c-b4b7-f0a719e96650"), "https://art.magusexperience.com/wp-content/uploads/2020/03/plabo.net-0616.jpg" },
                    { new Guid("feaadf70-eaba-4177-9e80-b1ec52c4247d"), new Guid("2c21f5d9-dc4e-4e2c-b4b7-f0a719e96650"), "https://art.magusexperience.com/wp-content/uploads/2020/03/plabo.net-0616.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("bcbf6201-48fc-4ea2-a167-793ac221b5a3"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("32688fbb-ba73-495a-9acd-81a2848fe603"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("46f00b54-6702-46d9-b847-b07e4c330fcf"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("593703e4-7390-4ac5-bf7c-403b57ee9ff3"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("80653e22-de9c-4484-8063-8cb8939a35ba"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("b1ac92c9-210a-4918-b1b7-24ec84ac6f04"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("b5e5fcdd-0436-4b6e-9886-dc05766892d7"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("feaadf70-eaba-4177-9e80-b1ec52c4247d"));

            migrationBuilder.DeleteData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("ad16eaf3-5686-4367-90d0-ab3a50146cc9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2c21f5d9-dc4e-4e2c-b4b7-f0a719e96650"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3dc4f47b-086a-417b-a056-43fc084cd25d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3fd28cb9-1944-4786-8cb3-1bd04a4b4d6c"));

            migrationBuilder.DeleteData(
                table: "Resorts",
                keyColumn: "Id",
                keyValue: new Guid("97dae8aa-2185-4a4f-81cf-983cdb3c0e7c"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528726ea-e421-4a80-b303-f035355599de",
                column: "ConcurrencyStamp",
                value: "2a623e37-0793-4583-9838-56a82146ec2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd65fa9-eb2c-4372-8084-8c501347e74f",
                column: "ConcurrencyStamp",
                value: "92b328ef-e3ff-4e44-a5d7-7d29c73d6463");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2536968-519d-42d7-9f8a-c14e56bad4ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd04b78b-9a60-4ef4-a98d-4e8e0341e88b", "AQAAAAEAACcQAAAAENGppRLctnKRzKMEnLfco4q5ZN1/CnA1jcuFp2ZVkvgnAKmaNZLI5zv3MGVtKvMSmA==", "e0cad4ad-b774-4d44-abec-1632c2842660" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e067e587-1b89-4dfb-a7dd-cee434dcfc0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69535d6b-a065-4b3c-b2a9-2da7d8338bd3", "AQAAAAEAACcQAAAAEPtal8pA3jkCWrdRrN/Ym9R0IboAA6h5OxOAl3oXzzTtsIfYshI/A+SNW0kKihdi3Q==", "4862fec3-d3cc-4e67-9ee4-009eb4417a25" });

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("32de8226-24d7-4085-9e1d-d9f5850f543c"),
                column: "Name",
                value: "Тракойската гробница");

            migrationBuilder.UpdateData(
                table: "Landmarks",
                keyColumn: "Id",
                keyValue: new Guid("4a9a7f60-babf-4582-b851-88bcba1bc831"),
                column: "CityId",
                value: new Guid("7a65d489-304c-4be8-b344-7d53a644e080"));
        }
    }
}
