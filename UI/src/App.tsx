import React from 'react';
import './App.css';
import { Button, Stack, Typography } from '@mui/material';
import { Container } from '@mui/material';
import { Box } from '@mui/material';
import Header from './components/Header';
import { CssBaseline } from '@mui/material';
import { createTheme, ThemeProvider } from '@mui/material/styles';
import Footer from './components/Footer';

const defaultTheme = createTheme();

function App() {
  return (
    <div className="App">
      <ThemeProvider theme={defaultTheme}>
        <CssBaseline />
        <Header />
        <main>
          <Box
            sx={{
            bgcolor: 'background.paper',
              pt: 8,
              pb: 6,
            }}
            >
            <Container maxWidth="sm">
              <Typography
                component="h1"
                variant="h2"
                align="center"
                color="text.primary"
                gutterBottom
                >
                Посмотрим вакансии и вилки зарплат?
              </Typography>
              <Typography variant="h5" align="center" color="text.secondary" paragraph>
                Собираем вакансии программистов и считаем по ним статистику. Получается весело,
                а иногда даже полезно :)
              </Typography>
              <Stack
                sx={{ pt: 4 }}
                direction="row"
                spacing={2}
                justifyContent="center"
                >
                <Button variant="contained">С газом</Button>
                <Button variant="outlined">Без газа</Button>
              </Stack>
            </Container>
          </Box>
        </main>
        <Footer />
	  </ThemeProvider>
    </div>
  );
}

export default App;
