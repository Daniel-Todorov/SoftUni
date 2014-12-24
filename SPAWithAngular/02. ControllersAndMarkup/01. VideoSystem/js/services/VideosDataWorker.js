'use strict';

app.factory('VideosDataWorker', [function () {

    function getVideos() {
        var videos;

        if (localStorage.videos === undefined) {
            videos = []
        } else {
            videos = JSON.parse(localStorage.videos);
        }

        return videos;
    }

    function addVideo(video) {
        var videos = getVideos();

        videos.push(video);

        localStorage.videos = JSON.stringify(videos);

        return true;
    }

    return {
        getVideos: getVideos,
        addVideo: addVideo
    };
}]);