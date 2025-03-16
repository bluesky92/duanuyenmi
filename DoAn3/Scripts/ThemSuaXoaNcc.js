var app = angular.module('Myapp', []);
app.controller('Mycontroller', function ($scope, $http) {
    $scope.getNcc = function () {
        $http.get("/Admin/QLNhacungcap/GetNcc").then(function (response) {
            $scope.myData = response.data;
            console.log($scope.myData);
        })
    }
    $scope.Them = function () {
        $scope.lvb = {};
        $scope.lvb.mancc = $scope.mancc;
        $scope.lvb.tenncc = $scope.tenncc;
        $scope.lvb.sdt = $scope.sdt;
        $scope.lvb.diachi = $scope.diachi;

        $http({
            method: "POST",
            url: "/Admin/QLNhacungcap/Insertdata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getNcc();
            $scope.mancc = "";
            $scope.tenncc = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })
    }
    $scope.Laydl = function (index) {
        $scope.mancc = $scope.myData[index].mancc;
        $scope.tenncc = $scope.myData[index].tenncc;
        $scope.diachi = $scope.myData[index].diachi;
        $scope.sdt = $scope.myData[index].sdt;
    };

    $scope.Sua = function () {
        $scope.lvb = {};
        $scope.lvb.mancc = $scope.mancc;
        $scope.lvb.tenncc = $scope.tenncc;
        $scope.lvb.diachi = $scope.diachi;
        $scope.lvb.sdt = $scope.sdt;
        $http({
            method: "POST",
            url: "/Admin/QLNhacungcap/Updatedata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getNcc();
            $scope.mancc = "";
            $scope.tenncc = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })
    }

    $scope.Delete = function (index) {
        $scope.mancc = $scope.myData[index].mancc;
        $scope.tenncc = $scope.myData[index].tenncc;
        $scope.sdt = $scope.myData[index].sdt;
        $scope.diachi = $scope.myData[index].diachi;
    };

    $scope.Oke = function (mancc) {
        $scope.lvb = {};
        $scope.lvb.mancc = $scope.mancc;
        $scope.lvb.tenncc = $scope.tenncc;
        $scope.lvb.sdt = $scope.sdt;
        $scope.lvb.diachi = $scope.diachi;
        $http({
            method: "POST",
            url: "/Admin/QLNhacungcap/Deletedata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getNcc();
            console.log(response);
            $scope.mancc = "";
            $scope.tenncc = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })
    }
});