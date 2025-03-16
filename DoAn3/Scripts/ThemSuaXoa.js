var app = angular.module('Myapp', []);
app.controller('Mycontroller', function ($scope, $http) {
    $scope.getNd = function () {
        $http.get("/Admin/QLNhanVien/GetNd").then(function (response) {
            $scope.myData = response.data;
            console.log($scope.myData);
        })
    }
    $scope.Them = function () {
        $scope.lvb = {};
        $scope.lvb.mand = $scope.mand;
        $scope.lvb.tennd = $scope.tennd;
        $scope.lvb.taikhoan = $scope.taikhoan;
        $scope.lvb.matkhau = $scope.matkhau;
        $scope.lvb.diachi = $scope.diachi;
        $scope.lvb.sdt = $scope.sdt;

        $http({
            method: "POST",
            url: "/Admin/QLNhanVien/Insertdata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getNd();
            $scope.mand = "";
            $scope.tennd = "";
            $scope.taikhoan = "";
            $scope.matkhau = "";
            $scope.diachi = "";
            $scope.sdt = "";

        })
    }
    $scope.Laydl = function (index) {
        $scope.mand = $scope.myData[index].mand;
        $scope.tennd = $scope.myData[index].tennd;
        $scope.taikhoan = $scope.myData[index].taikhoan;
        $scope.matkhau = $scope.myData[index].matkhau;
        $scope.diachi = $scope.myData[index].diachi;
        $scope.sdt = $scope.myData[index].sdt;
    };

    $scope.Sua = function () {
        $scope.lvb = {};
        $scope.lvb.mand = $scope.mand;
        $scope.lvb.tennd = $scope.tennd;
        $scope.lvb.taikhoan = $scope.taikhoan;
        $scope.lvb.matkhau = $scope.matkhau;
        $scope.lvb.diachi = $scope.diachi;
        $scope.lvb.sdt = $scope.sdt;
        $http({
            method: "POST",
            url: "/Admin/QLNhanVien/Updatedata",
            data: JSON.stringify($scope.lvb)
        }).then(function (response) {
            $scope.getNd();
            $scope.mand = "";
            $scope.tennd = "";
            $scope.taikhoan = "";
            $scope.matkhau = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })
    }

    $scope.Delete = function (index) {
        $scope.mand = $scope.myData[index].mand;
        $scope.tennd = $scope.myData[index].tennd;
        $scope.taikhoan = $scope.myData[index].taikhoan;
        $scope.matkhau = $scope.myData[index].matkhau;
        $scope.diachi = $scope.myData[index].diachi;
        $scope.sdt = $scope.myData[index].sdt;
    };

    $scope.Oke = function (mand) {
        $scope.lvb = {};
        $scope.lvb.mand = $scope.mand;
        $scope.lvb.taikhoan = $scope.taikhoan;
        $scope.lvb.matkhau = $scope.matkhau;
        $scope.lvb.tennd = $scope.tennd;       
        $scope.lvb.sdt = $scope.sdt;
        $scope.lvb.diachi = $scope.diachi;        
        $http({
            method: "POST",    
            url: "/Admin/QLNhanVien/Deletedata",    
            data: JSON.stringify($scope.lvb)    
        }).then(function (response) {    
            $scope.getNd();    
            console.log(response); 
            $scope.mand = "";
            $scope.tennd = "";
            $scope.taikhoan = "";
            $scope.matkhau = "";
            $scope.sdt = "";
            $scope.diachi = "";
        })               
    }
});