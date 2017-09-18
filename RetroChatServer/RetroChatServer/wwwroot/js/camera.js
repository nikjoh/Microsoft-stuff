var camera = {
    takePicture: function () {
        if (!navigator.camera) {
            alert("Camera API not supported");
            return;
        }
        var options = {
            quality: 50,
            destinationType: Camera.DestinationType.DATA_URL,
            sourceType: Camera.PictureSourceType.CAMERA,
            allowEdit: true,
            encodingType: Camera.EncodingType.PNG,
            targetWidth: 100,
            targetHeight: 100,
            popoverOptions: CameraPopoverOptions,
            saveToPhotoAlbum: false,
            correctOrientation: true
        };
        navigator.camera.getPicture(function (imageData) {
            var image = document.getElementById('postImage');
            image.src = "data:image/png;base64," + imageData;
        }, function () {
            // error
            }, options);
        return false;
    }
    
};
