var app = angular.module('Myapp', []);
app.controller('Mycontroller', function ($scope, $http) {
    $scope.getKh = function () {
        $http.get("/Admin/QLKhachhang/GetKh").then(function (response) {
            $scope.myData = response.data;
            console.log($scope.myData);
        })
    }
    $scope.Them = function () {
        $scope.lvb = {};
        $scope.lvb.makh = $scope.makh;
        $scope.lvb.tenkh = $scope.tenkh;
        $scope.lvb.sdt = $scope.sdt;
        $scope.lvb.diachi = $scope.diachi;

        $http({
            method: "POST",
            url: "/Admin/QLKhachhang/Insertdata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getKh();
            $scope.makh = "";
            $scope.tenkh = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })
    }
    $scope.Laydl = function (index) {
        $scope.makh = $scope.myData[index].makh;
        $scope.tenkh = $scope.myData[index].tenkh;
        $scope.diachi = $scope.myData[index].diachi;
        $scope.sdt = $scope.myData[index].sdt;
    };

    $scope.Sua = function () {
        $scope.lvb = {};
        $scope.lvb.makh = $scope.makh;
        $scope.lvb.tenkh = $scope.tenkh;
        $scope.lvb.diachi = $scope.diachi;
        $scope.lvb.sdt = $scope.sdt;
        $http({
            method: "POST",
            url: "/Admin/QLKhachhang/Updatedata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getKh();
            $scope.makh = "";
            $scope.tenkh = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })
    }

    $scope.Delete = function (index) {
        $scope.makh = $scope.myData[index].makh;
        $scope.tenkh = $scope.myData[index].tenkh;
        $scope.sdt = $scope.myData[index].sdt;
        $scope.diachi = $scope.myData[index].diachi;
    };

    $scope.Oke = function (makh) {
        $scope.lvb = {};
        $scope.lvb.makh = $scope.makh;
        $scope.lvb.tenkh = $scope.tenkh;
        $scope.lvb.sdt = $scope.sdt;
        $scope.lvb.diachi = $scope.diachi;
        $http({
            method: "POST",
            url: "/Admin/QLKhachhang/Deletedata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getKh();
            console.log(response);
            $scope.makh = "";
            $scope.tenkh = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })
    }
});