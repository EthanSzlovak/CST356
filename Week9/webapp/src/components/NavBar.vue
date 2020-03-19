<template>
  <div class="links">
    <span v-if="$auth.isAuthenticated" v-on:click='goToHome'>Home</span>
    <span v-if="$auth.isAuthenticated" v-on:click='goToTables'>Students</span>
    <span v-if="$auth.isAuthenticated" v-on:click='goToForms'>Instructors</span>
    <div v-if="!$auth.loading">
      <button v-if="!$auth.isAuthenticated" @click="login">Log in</button>
      <button v-if="$auth.isAuthenticated" @click="logout">Log out</button>
      </div>
  </div>
</template>

<script>
  export default {
    name: 'NavBar',
    methods: {
      goToHome: function() {
        this.$router.push({ path: 'home' })
      },
      goToTables: function() {
        this.$router.push({ path: 'students' })
      },
      goToForms: function() {
        this.$router.push({ path: 'instructors' })
      },
      login() {
      this.$auth.loginWithRedirect();
      },
      // Log the user out
      logout() {
       this.$auth.logout({
        returnTo: window.location.origin
      });
      }
    }
  }
</script>

<style scoped>
  span {
      font-family: monospace;
      font-weight: bold;
      font-size: 14pt;
      cursor: pointer;
      padding-right: 20px;
      background-color: white;
      text-align: center;
  }
  .links {
      background-color: lightgray;
      margin-top: 20px;
      padding: 10px;
  }
</style>