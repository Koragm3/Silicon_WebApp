
document.addEventListener('DOMContentLoaded', function () {
        handleProfileImageUpload()
})

function handleProfileImageUpload() {
    try {
        let fileUploader = document.querySelector('#fileUploader')
        
        if (fileUploader != undefined) {
            fileUploader.addEventListener('change', function () {               
                if (this.files.length > 0) {
                    this.form.submit()
                }
            })
        }
    }
    catch { }
}





document.addEventListener('DOMContentLoaded', function () {
    var form = document.querySelector('form');
form.addEventListener('submit', function (event) {
        var isValid = true;


var inputs = form.querySelectorAll('input');
inputs.forEach(function (input) {
            if (input.value.trim() === '') {
    isValid = false;
var errorMessage = input.nextElementSibling;
errorMessage.innerText = 'This field is required.';
            }
        });

if (!isValid) {
    event.preventDefault();
        }
    });


form.addEventListener('focus', function (event) {
        if (event.target.tagName === 'INPUT') {
            var errorMessage = event.target.nextElementSibling;
errorMessage.innerText = '';
        }
    }, true); 
});
  

