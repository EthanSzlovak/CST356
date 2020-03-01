function validate() {
    
    document.getElementById('first-name-error').style.visibility = 'hidden';
    document.getElementById('password-error').style.visibility = 'hidden';

    var username = document.getElementById('first-name').value;
    var password = document.getElementById('password').value;

    if (username == '') {
        document.getElementById('first-name-error').style.visibility = 'visible';
    }

    if (password == '') {
        document.getElementById('password-error').style.visibility = 'visible';
    }
}