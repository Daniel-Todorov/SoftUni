app.controller('TigerController', function ($scope) {

    var tigerInfo = {
        'Name': 'Pesho',
        'Born': 'Asia',
        'BirthDate': 2006,
        'Live': 'Sofia Zoo'
    };

    tigerInfo.Image = 'http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg';

    $scope.tigerInfo = tigerInfo;

    $scope.sectionStyle = {
        width: '600px',
        padding: '2em',
        fontFamily: 'Tahoma',
        color: '#192e42',
        backgroundColor: '#cacaca'
    };

    $scope.leftSide = {
        display: 'inline-block',
        width: '45%',
        verticalAlign: 'top'
    };

    $scope.titleStyle = {
        textAlign: 'center',
        textTransform: 'uppercase'
    };

    $scope.rightSide = {
        display: 'inline-block',
        width: '50%'
    }
});
