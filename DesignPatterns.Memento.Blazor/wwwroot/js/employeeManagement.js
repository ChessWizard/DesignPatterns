(function (window) {
    window.checkCreateEmployee =
        window.checkCreateEmployee ||
        function () {

            var nameValue = document.getElementById("employee-name").value;
            var surnameValue = document.getElementById("employee-surname").value;
            var ageValue = document.getElementById("employee-age").value;
            var citizenNumberValue = document.getElementById("employee-citizennumber").value;

            // Eğer herhangi bir input boşsa employee yaratma butonuna tıklanamasın
            if (nameValue == "" || surnameValue == ""
                || ageValue == 0 || ageValue < 0 || citizenNumberValue == "") {
                return false;
            }
            return true;
        }
})(window);

